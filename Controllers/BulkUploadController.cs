using DV.API.Data;
using DV.API.Services;
using DV.Shared.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Components.Authorization;
using DV.Shared.Security;
using System.Diagnostics;
using System.Text.Json;

namespace DV.API.Controllers;

/// <summary>
/// API Controller for bulk document upload operations.
/// Supports multi-file upload with per-file metadata, ZIP extraction, and CSV-driven import.
/// NIST SP 800-53: SI-10 (Input Validation), AU-3 (Audit Content)
/// </summary>
[ApiController]
[Route("api/[controller]")]
[Authorize]
public class BulkUploadController : ControllerBase
{
    private readonly DocumentUploadService _uploadService;
    private readonly FileUploadSecurityService _securityService;
    private readonly DocumentRepository _repo;
    private readonly NotificationService _notificationService;
    private readonly AppDbContext _context;
    private readonly ILogger<BulkUploadController> _logger;
    private readonly IDbContextFactory<SecurityDbContext> _securityDbContextFactory;

    private const int MaxFilesPerBatch = 100;
    private const long MaxTotalBatchSize = 500L * 1024 * 1024; // 500MB

    public BulkUploadController(
        DocumentUploadService uploadService,
        FileUploadSecurityService securityService,
        DocumentRepository repo,
        NotificationService notificationService,
        AppDbContext context,
        ILogger<BulkUploadController> logger,
        IDbContextFactory<SecurityDbContext> securityDbContextFactory)
    {
        _uploadService = uploadService;
        _securityService = securityService;
        _repo = repo;
        _notificationService = notificationService;
        _context = context;
        _logger = logger;
        _securityDbContextFactory = securityDbContextFactory;
    }

    /// <summary>
    /// Bulk upload files with metadata. Files sent as multipart form data,
    /// metadata as a JSON field named "metadata".
    /// </summary>
    [HttpPost("upload")]
    [RequestSizeLimit(500_000_000)] // 500MB
    [RequestFormLimits(MultipartBodyLengthLimit = 500_000_000)]
    public async Task<ActionResult<BulkUploadResult>> UploadBatch()
    {
        var stopwatch = Stopwatch.StartNew();

        // Parse metadata from form
        if (!Request.Form.TryGetValue("metadata", out var metadataJson))
            return BadRequest(new { error = "Missing 'metadata' field in form data" });

        BulkUploadRequest? request;
        try
        {
            request = JsonSerializer.Deserialize<BulkUploadRequest>(metadataJson.ToString(),
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
        }
        catch (JsonException ex)
        {
            return BadRequest(new { error = $"Invalid metadata JSON: {ex.Message}" });
        }

        if (request == null)
            return BadRequest(new { error = "Metadata deserialization returned null" });

        // Validate project access
        var userId = await GetCurrentUserIdAsync();
        if (userId == 0)
            return Unauthorized(new { error = "Could not resolve user identity" });

        var hasAccess = await _repo.HasProjectEditAccessAsync(User, request.ProjectId);
        if (!hasAccess)
            return Forbid();

        // Validate batch constraints
        var files = Request.Form.Files;
        if (files.Count == 0)
            return BadRequest(new { error = "No files provided" });

        if (files.Count > MaxFilesPerBatch)
            return BadRequest(new { error = $"Maximum {MaxFilesPerBatch} files per batch. You sent {files.Count}." });

        long totalSize = files.Sum(f => f.Length);
        if (totalSize > MaxTotalBatchSize)
            return BadRequest(new { error = $"Total batch size {totalSize / (1024 * 1024)}MB exceeds maximum of {MaxTotalBatchSize / (1024 * 1024)}MB" });

        // Get user roles for security validation
        var userRoles = User.Claims
            .Where(c => c.Type == System.Security.Claims.ClaimTypes.Role || c.Type == "role")
            .Select(c => c.Value)
            .ToArray();

        var result = new BulkUploadResult { TotalFiles = files.Count };
        var fileResults = new List<BulkUploadFileResult>();

        _logger.LogInformation("Starting bulk upload: {FileCount} files, {TotalSize}MB to schema {Schema}",
            files.Count, totalSize / (1024 * 1024), request.SchemaName);

        // Process each file
        foreach (var file in files)
        {
            var fileResult = new BulkUploadFileResult
            {
                FileName = file.FileName,
                ClientFileId = file.Name // form field name is used as clientFileId
            };

            try
            {
                // Find matching metadata
                var meta = request.FileMetadata
                    .FirstOrDefault(m => m.ClientFileId == file.Name || m.FileName == file.FileName);

                // Security validation
                var secResult = await _securityService.ValidateFileAsync(file, userRoles);
                if (!secResult.IsValid)
                {
                    fileResult.Success = false;
                    fileResult.Error = $"Security validation failed: {string.Join("; ", secResult.Errors)}";
                    fileResults.Add(fileResult);
                    result.FailedCount++;
                    continue;
                }

                // Create document with full metadata
                var documentId = await CreateDocumentWithMetadataAsync(
                    request.SchemaName, request.ProjectId, file.FileName, meta, userId);

                // Read file bytes and create page
                byte[] fileContent;
                using (var ms = new MemoryStream())
                {
                    await file.CopyToAsync(ms);
                    fileContent = ms.ToArray();
                }

                var checksumMD5 = CalculateMD5(fileContent);
                var fileExtension = Path.GetExtension(file.FileName).ToLowerInvariant();
                var contentType = file.ContentType ?? GetContentType(fileExtension);

                var documentPage = new DocumentPage(
                    pageId: 0,
                    documentId: documentId,
                    documentIndex: meta?.DocumentIndex ?? "",
                    pageNumber: 1,
                    fileName: file.FileName,
                    fileType: fileExtension.TrimStart('.').ToUpperInvariant(),
                    fileContent: fileContent,
                    contentType: contentType,
                    createdBy: userId,
                    checksumMD5: checksumMD5
                );

                var pageId = await SaveDocumentPageAsync(documentPage, request.SchemaName);

                fileResult.Success = true;
                fileResult.DocumentId = documentId;
                fileResult.PageId = pageId;
                result.SuccessCount++;

                _logger.LogInformation("Bulk upload: file '{FileName}' → DocumentId={DocId}, PageId={PageId}",
                    file.FileName, documentId, pageId);
            }
            catch (Exception ex)
            {
                fileResult.Success = false;
                fileResult.Error = ex.Message;
                result.FailedCount++;
                _logger.LogError(ex, "Bulk upload failed for file '{FileName}'", file.FileName);
            }

            fileResults.Add(fileResult);
        }

        stopwatch.Stop();
        result.FileResults = fileResults;
        result.Duration = stopwatch.Elapsed;

        // Send notification
        try
        {
            await _notificationService.CreateNotificationAsync(new DV.Shared.DTOs.CreateNotificationDto
            {
                UserId = userId,
                Title = "Bulk Upload Complete",
                Message = $"Uploaded {result.SuccessCount}/{result.TotalFiles} files to {request.SchemaName}. " +
                    $"{result.FailedCount} failed. Duration: {result.Duration.TotalSeconds:F1}s",
                Category = "DocumentUpload",
                IsImportant = result.FailedCount > 0
            });
        }
        catch (Exception ex)
        {
            _logger.LogWarning(ex, "Failed to send bulk upload notification");
        }

        return Ok(result);
    }

    /// <summary>
    /// Download the CSV template for bulk upload
    /// </summary>
    [HttpGet("csv-template")]
    public IActionResult DownloadCsvTemplate()
    {
        var csv = BulkUploadCsvTemplate.GenerateHeaderRow() + "\n" +
                  BulkUploadCsvTemplate.GenerateSampleRow() + "\n";
        return File(System.Text.Encoding.UTF8.GetBytes(csv), "text/csv", "bulk-upload-template.csv");
    }

    /// <summary>
    /// Validate files without uploading (dry run)
    /// </summary>
    [HttpPost("validate")]
    [RequestSizeLimit(500_000_000)]
    [RequestFormLimits(MultipartBodyLengthLimit = 500_000_000)]
    public async Task<ActionResult<List<BulkUploadFileResult>>> ValidateBatch()
    {
        var userRoles = User.Claims
            .Where(c => c.Type == System.Security.Claims.ClaimTypes.Role || c.Type == "role")
            .Select(c => c.Value)
            .ToArray();

        var results = new List<BulkUploadFileResult>();
        foreach (var file in Request.Form.Files)
        {
            var secResult = await _securityService.ValidateFileAsync(file, userRoles);
            results.Add(new BulkUploadFileResult
            {
                FileName = file.FileName,
                ClientFileId = file.Name,
                Success = secResult.IsValid,
                Error = secResult.IsValid ? null : string.Join("; ", secResult.Errors)
            });
        }
        return Ok(results);
    }

    // ── Private helpers ──

    /// <summary>
    /// Creates a Document row with full metadata (including custom Text/Date/Boolean/Number fields)
    /// </summary>
    private async Task<int> CreateDocumentWithMetadataAsync(
        string schemaName, int projectId, string fileName,
        BulkUploadFileMetadata? meta, int userId)
    {
        var fileExtension = Path.GetExtension(fileName).ToLowerInvariant();
        var documentNumber = $"DOC_{DateTime.UtcNow:yyyyMMdd}_{Guid.NewGuid().ToString("N")[..8].ToUpper()}";
        var documentType = fileExtension.TrimStart('.').ToUpperInvariant();
        var publicToken = DV.Shared.Constants.DocumentTokenGenerator.GenerateToken();

        var sql = $@"
            INSERT INTO ""{schemaName}"".""Document""
            (""ProjectId"", ""DocumentNumber"", ""DocumentType"", ""DocumentIndex"", ""Title"", ""Author"",
             ""DocumentDate"", ""Keywords"", ""Memo"", ""Status"", ""Classification"", ""Version"", ""Issue"",
             ""Text01"", ""Text02"", ""Text03"", ""Text04"", ""Text05"", ""Text06"",
             ""Text07"", ""Text08"", ""Text09"", ""Text10"", ""Text11"", ""Text12"",
             ""Date01"", ""Date02"", ""Date03"", ""Date04"",
             ""Boolean01"", ""Boolean02"", ""Boolean03"",
             ""Number01"", ""Number02"", ""Number03"",
             ""PublicToken"", ""CreatedOn"", ""CreatedBy"")
            VALUES
            (@ProjectId, @DocumentNumber, @DocumentType, @DocumentIndex, @Title, @Author,
             @DocumentDate, @Keywords, @Memo, @Status, @Classification, @Version, @Issue,
             @Text01, @Text02, @Text03, @Text04, @Text05, @Text06,
             @Text07, @Text08, @Text09, @Text10, @Text11, @Text12,
             @Date01, @Date02, @Date03, @Date04,
             @Boolean01, @Boolean02, @Boolean03,
             @Number01, @Number02, @Number03,
             @PublicToken, @CreatedOn, @CreatedBy)
            RETURNING ""DocumentId""";

        var p = new Func<string, object?, Npgsql.NpgsqlParameter>(
            (name, val) => new Npgsql.NpgsqlParameter(name, val ?? (object)DBNull.Value));

        var documentIds = await _context.Database.SqlQueryRaw<int>(sql,
            p("@ProjectId", projectId),
            p("@DocumentNumber", documentNumber),
            p("@DocumentType", documentType),
            p("@DocumentIndex", meta?.DocumentIndex),
            p("@Title", meta?.Title ?? Path.GetFileNameWithoutExtension(fileName)),
            p("@Author", meta?.Author),
            p("@DocumentDate", meta?.DocumentDate),
            p("@Keywords", meta?.Keywords),
            p("@Memo", meta?.Memo),
            p("@Status", meta?.Status ?? "Draft"),
            p("@Classification", meta?.Classification),
            p("@Version", meta?.Version),
            p("@Issue", meta?.Issue),
            p("@Text01", meta?.Text01), p("@Text02", meta?.Text02),
            p("@Text03", meta?.Text03), p("@Text04", meta?.Text04),
            p("@Text05", meta?.Text05), p("@Text06", meta?.Text06),
            p("@Text07", meta?.Text07), p("@Text08", meta?.Text08),
            p("@Text09", meta?.Text09), p("@Text10", meta?.Text10),
            p("@Text11", meta?.Text11), p("@Text12", meta?.Text12),
            p("@Date01", meta?.Date01), p("@Date02", meta?.Date02),
            p("@Date03", meta?.Date03), p("@Date04", meta?.Date04),
            p("@Boolean01", meta?.Boolean01), p("@Boolean02", meta?.Boolean02),
            p("@Boolean03", meta?.Boolean03),
            p("@Number01", meta?.Number01), p("@Number02", meta?.Number02),
            p("@Number03", meta?.Number03),
            p("@PublicToken", publicToken),
            p("@CreatedOn", DateTime.UtcNow),
            p("@CreatedBy", userId)
        ).ToListAsync();

        if (!documentIds.Any())
            throw new InvalidOperationException("Failed to create document — no ID returned");

        return documentIds.First();
    }

    private async Task<int> SaveDocumentPageAsync(DocumentPage page, string schemaName)
    {
        var sql = $@"
            INSERT INTO ""{schemaName}"".""DocumentPage""
            (""DocumentId"", ""DocumentIndex"", ""PageNumber"", ""PageReference"", ""FileName"", ""FilePath"", ""FileType"",
             ""FrameNumber"", ""Level1"", ""Level2"", ""Level3"", ""Level4"", ""DiskNumber"", ""FileFormat"", ""PageSize"",
             ""FileContent"", ""FileSize"", ""ContentType"", ""UploadedDate"", ""ChecksumMD5"", ""StorageType"", ""CreatedOn"", ""CreatedBy"")
            VALUES
            (@DocumentId, @DocumentIndex, @PageNumber, @PageReference, @FileName, @FilePath, @FileType,
             @FrameNumber, @Level1, @Level2, @Level3, @Level4, @DiskNumber, @FileFormat, @PageSize,
             @FileContent, @FileSize, @ContentType, @UploadedDate, @ChecksumMD5, @StorageType, @CreatedOn, @CreatedBy)
            RETURNING ""PageId""";

        var p = new Func<string, object?, Npgsql.NpgsqlParameter>(
            (name, val) => new Npgsql.NpgsqlParameter(name, val ?? (object)DBNull.Value));

        var pageIds = await _context.Database.SqlQueryRaw<int>(sql,
            p("@DocumentId", page.DocumentId),
            p("@DocumentIndex", page.DocumentIndex),
            p("@PageNumber", page.PageNumber),
            p("@PageReference", page.PageReference),
            p("@FileName", page.FileName),
            p("@FilePath", page.FilePath),
            p("@FileType", page.FileType),
            p("@FrameNumber", page.FrameNumber),
            p("@Level1", page.Level1),
            p("@Level2", page.Level2),
            p("@Level3", page.Level3),
            p("@Level4", page.Level4),
            p("@DiskNumber", page.DiskNumber),
            p("@FileFormat", page.FileFormat),
            p("@PageSize", page.PageSize),
            p("@FileContent", page.FileContent!),
            p("@FileSize", page.FileSize!),
            p("@ContentType", page.ContentType!),
            p("@UploadedDate", page.UploadedDate ?? DateTime.UtcNow),
            p("@ChecksumMD5", page.ChecksumMD5!),
            p("@StorageType", (int)page.StorageType),
            p("@CreatedOn", page.CreatedOn),
            p("@CreatedBy", page.CreatedBy)
        ).ToListAsync();

        if (!pageIds.Any())
            throw new InvalidOperationException("Failed to create document page — no PageId returned");

        return pageIds.First();
    }

    private async Task<int> GetCurrentUserIdAsync()
    {
        var username = User.Identity?.Name;
        if (string.IsNullOrEmpty(username)) return 0;

        using var securityContext = await _securityDbContextFactory.CreateDbContextAsync();
        var user = await securityContext.Users.FirstOrDefaultAsync(u => u.Username == username);
        return user?.UserId ?? 0;
    }

    private static string CalculateMD5(byte[] data)
    {
        using var md5 = System.Security.Cryptography.MD5.Create();
        var hash = md5.ComputeHash(data);
        return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
    }

    private static string GetContentType(string extension) => extension switch
    {
        ".pdf" => "application/pdf",
        ".tiff" or ".tif" => "image/tiff",
        ".jpg" or ".jpeg" => "image/jpeg",
        ".png" => "image/png",
        ".bmp" => "image/bmp",
        ".gif" => "image/gif",
        _ => "application/octet-stream"
    };
}

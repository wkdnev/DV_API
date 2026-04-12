using System.Collections.Concurrent;
using System.IO.Compression;
using System.Text;
using DV.API.Data;
using DV.Shared.DTOs;
using DV.Shared.Models;
using DV.Shared.Security;
using Microsoft.EntityFrameworkCore;

namespace DV.API.Services;

/// <summary>
/// Service that performs bulk export operations — querying documents, 
/// extracting blob data, building CSV and ZIP packages.
/// </summary>
public class BulkExportService
{
    private readonly IServiceScopeFactory _scopeFactory;
    private readonly ILogger<BulkExportService> _logger;

    /// <summary>
    /// In-memory job status tracker. Jobs are kept for 24 hours after completion.
    /// </summary>
    public static readonly ConcurrentDictionary<Guid, BulkExportJobStatus> Jobs = new();

    /// <summary>
    /// Cancellation sources keyed by job ID.
    /// </summary>
    public static readonly ConcurrentDictionary<Guid, CancellationTokenSource> CancellationSources = new();

    public BulkExportService(
        IServiceScopeFactory scopeFactory,
        ILogger<BulkExportService> logger)
    {
        _scopeFactory = scopeFactory;
        _logger = logger;
    }

    /// <summary>
    /// Get the count of documents matching the filter criteria (for preview).
    /// </summary>
    public async Task<int> GetFilteredDocumentCountAsync(BulkExportRequest request)
    {
        using var scope = _scopeFactory.CreateScope();
        var context = scope.ServiceProvider.GetRequiredService<AppDbContext>();
        var documents = await QueryDocumentsAsync(context, request, CancellationToken.None);
        return documents.Count;
    }

    /// <summary>
    /// Execute a bulk export job. Called by the background service.
    /// </summary>
    public async Task ExecuteExportAsync(ExportWorkItem workItem, CancellationToken stoppingToken)
    {
        var jobId = workItem.JobId;
        var request = workItem.Request;
        var linkedCts = CancellationTokenSource.CreateLinkedTokenSource(
            stoppingToken, workItem.CancellationSource.Token);
        var ct = linkedCts.Token;

        var job = Jobs.GetOrAdd(jobId, _ => new BulkExportJobStatus
        {
            JobId = jobId,
            SchemaName = request.SchemaName,
            ProjectId = request.ProjectId,
            OutputFormat = request.OutputFormat,
            UserId = workItem.UserId,
            Status = BulkExportStatuses.Processing
        });

        job.Status = BulkExportStatuses.Processing;
        job.StartedAt = DateTime.UtcNow;

        var tempDir = Path.Combine(Path.GetTempPath(), "DV_Export", jobId.ToString());

        try
        {
            Directory.CreateDirectory(tempDir);

            using var scope = _scopeFactory.CreateScope();
            var context = scope.ServiceProvider.GetRequiredService<AppDbContext>();
            var notificationService = scope.ServiceProvider.GetRequiredService<NotificationService>();

            // Get project name
            var project = await context.Projects
                .FirstOrDefaultAsync(p => p.ProjectId == request.ProjectId, ct);
            job.ProjectName = project?.ProjectName ?? request.SchemaName;

            // Query documents
            var documents = await QueryDocumentsAsync(context, request, ct);
            job.TotalDocuments = documents.Count;

            if (documents.Count == 0)
            {
                job.Status = BulkExportStatuses.Completed;
                job.CompletedAt = DateTime.UtcNow;
                await SendNotificationAsync(notificationService, workItem, job);
                return;
            }

            _logger.LogInformation("Export job {JobId}: exporting {Count} documents from {Schema}",
                jobId, documents.Count, request.SchemaName);

            // Build CSV content (BulkUploadCsvTemplate-compatible)
            var csvBuilder = new StringBuilder();
            csvBuilder.AppendLine(BulkUploadCsvTemplate.GenerateHeaderRow());

            var filesDir = Path.Combine(tempDir, "files");
            if (request.IncludeFiles)
                Directory.CreateDirectory(filesDir);

            foreach (var doc in documents)
            {
                ct.ThrowIfCancellationRequested();

                try
                {
                    // Get document pages for files
                    string? primaryFileName = null;

                    if (request.IncludeFiles)
                    {
                        var pages = await GetDocumentPagesAsync(context, request.SchemaName, doc.DocumentId, ct);

                        foreach (var page in pages)
                        {
                            if (page.FileContent != null && page.FileContent.Length > 0)
                            {
                                // Ensure unique filename
                                var exportFileName = GetUniqueFileName(filesDir, page.FileName);
                                var filePath = Path.Combine(filesDir, exportFileName);
                                await File.WriteAllBytesAsync(filePath, page.FileContent, ct);

                                job.ExportedFiles++;
                                job.ExportSizeBytes += page.FileContent.Length;

                                if (primaryFileName == null)
                                    primaryFileName = exportFileName;
                            }
                            else if (!string.IsNullOrEmpty(page.FilePath) && File.Exists(page.FilePath))
                            {
                                var exportFileName = GetUniqueFileName(filesDir, page.FileName);
                                var filePath = Path.Combine(filesDir, exportFileName);
                                File.Copy(page.FilePath, filePath, overwrite: true);

                                var fileInfo = new FileInfo(filePath);
                                job.ExportedFiles++;
                                job.ExportSizeBytes += fileInfo.Length;

                                if (primaryFileName == null)
                                    primaryFileName = exportFileName;
                            }
                        }
                    }

                    // Add CSV row
                    csvBuilder.AppendLine(BuildCsvRow(doc, primaryFileName));
                    job.ExportedDocuments++;
                    job.CurrentFile = primaryFileName ?? doc.DocumentNumber;
                }
                catch (Exception ex)
                {
                    job.FailedFiles++;
                    job.Errors.Add($"Document {doc.DocumentId}: {ex.Message}");
                    _logger.LogWarning(ex, "Export job {JobId}: failed to export document {DocId}", jobId, doc.DocumentId);
                }
            }

            // Write CSV
            var csvPath = Path.Combine(tempDir, "metadata.csv");
            await File.WriteAllTextAsync(csvPath, csvBuilder.ToString(), Encoding.UTF8, ct);

            // Create output
            if (request.OutputFormat == "Zip")
            {
                var zipPath = Path.Combine(Path.GetTempPath(), "DV_Export", $"{jobId}.zip");
                if (File.Exists(zipPath))
                    File.Delete(zipPath);

                ZipFile.CreateFromDirectory(tempDir, zipPath, CompressionLevel.Optimal, false);
                job.OutputPath = zipPath;

                var zipInfo = new FileInfo(zipPath);
                job.ExportSizeBytes = zipInfo.Length;
            }
            else
            {
                // Folder output — move to specified path
                var targetDir = request.OutputPath ?? tempDir;
                if (targetDir != tempDir)
                {
                    Directory.CreateDirectory(targetDir);
                    CopyDirectory(tempDir, targetDir);
                }
                job.OutputPath = targetDir;
            }

            job.Status = BulkExportStatuses.Completed;
            job.CompletedAt = DateTime.UtcNow;
            job.CurrentFile = null;

            _logger.LogInformation("Export job {JobId}: completed. {Docs} documents, {Files} files, {Size}MB",
                jobId, job.ExportedDocuments, job.ExportedFiles,
                Math.Round(job.ExportSizeBytes / (1024.0 * 1024.0), 1));

            await SendNotificationAsync(notificationService, workItem, job);
        }
        catch (OperationCanceledException)
        {
            job.Status = BulkExportStatuses.Cancelled;
            job.CompletedAt = DateTime.UtcNow;
            _logger.LogInformation("Export job {JobId}: cancelled", jobId);

            using var scope = _scopeFactory.CreateScope();
            var notificationService = scope.ServiceProvider.GetRequiredService<NotificationService>();
            await SendNotificationAsync(notificationService, workItem, job);
        }
        catch (Exception ex)
        {
            job.Status = BulkExportStatuses.Failed;
            job.Error = ex.Message;
            job.CompletedAt = DateTime.UtcNow;
            _logger.LogError(ex, "Export job {JobId}: failed", jobId);

            using var scope = _scopeFactory.CreateScope();
            var notificationService = scope.ServiceProvider.GetRequiredService<NotificationService>();
            await SendNotificationAsync(notificationService, workItem, job);
        }
        finally
        {
            CancellationSources.TryRemove(jobId, out _);

            // Clean up temp files (but not the ZIP) after a delay
            _ = Task.Run(async () =>
            {
                await Task.Delay(TimeSpan.FromHours(1));
                try
                {
                    if (Directory.Exists(tempDir))
                        Directory.Delete(tempDir, recursive: true);

                    // Clean up job status after 24 hours
                    await Task.Delay(TimeSpan.FromHours(23));
                    Jobs.TryRemove(jobId, out _);

                    // Also clean up the ZIP if it's still there
                    var zipPath = Path.Combine(Path.GetTempPath(), "DV_Export", $"{jobId}.zip");
                    if (File.Exists(zipPath))
                        File.Delete(zipPath);
                }
                catch { /* best effort cleanup */ }
            });
        }
    }

    private async Task<List<Document>> QueryDocumentsAsync(
        AppDbContext context, BulkExportRequest request, CancellationToken ct)
    {
        var sql = new StringBuilder();
        sql.Append($"SELECT \"DocumentId\", \"ProjectId\", \"DocumentIndex\", \"Issue\", \"DocumentStatus\", \"DocumentNumber\", ");
        sql.Append("\"Title\", \"Author\", \"DocumentDate\", \"Keywords\", \"Memo\", \"DocumentType\", \"OldDM\", \"CM\", \"GM\", \"EM\", ");
        sql.Append("\"Text01\", \"Text02\", \"Text03\", \"Text04\", \"Text05\", \"Text06\", \"Text07\", \"Text08\", \"Text09\", \"Text10\", \"Text11\", \"Text12\", ");
        sql.Append("\"Date01\", \"Date02\", \"Date03\", \"Date04\", \"Boolean01\", \"Boolean02\", \"Boolean03\", ");
        sql.Append("\"Number01\", \"Number02\", \"Number03\", \"Version\", \"Status\", \"Classification\", \"FilePath\", ");
        sql.Append($"\"CreatedOn\", \"CreatedBy\", \"ModifiedOn\", \"ModifiedBy\", \"PublicToken\" FROM \"{request.SchemaName}\".\"Document\" ");
        sql.Append($"WHERE \"ProjectId\" = {{{0}}}");

        var parameters = new List<object> { request.ProjectId };

        if (request.ExportMode == "Filtered")
        {
            // Structured filters take precedence over legacy SearchTerm
            if (request.Filters != null && request.Filters.HasAnyFilter())
            {
                AppendStructuredFilters(sql, parameters, request.Filters);
            }
            else if (!string.IsNullOrWhiteSpace(request.SearchTerm))
            {
                var searchPattern = $"%{request.SearchTerm}%";
                sql.Append($" AND (\"Title\" LIKE {{{parameters.Count}}} OR \"Author\" LIKE {{{parameters.Count + 1}}} OR \"DocumentNumber\" LIKE {{{parameters.Count + 2}}} OR \"Keywords\" LIKE {{{parameters.Count + 3}}})");
                parameters.Add(searchPattern);
                parameters.Add(searchPattern);
                parameters.Add(searchPattern);
                parameters.Add(searchPattern);
            }
        }

        sql.Append(" ORDER BY \"DocumentId\"");

        return await context.Database
            .SqlQueryRaw<Document>(sql.ToString(), parameters.ToArray())
            .ToListAsync(ct);
    }

    // Allowed column names for custom field rules — whitelist to prevent SQL injection
    private static readonly HashSet<string> AllowedColumns = new(StringComparer.OrdinalIgnoreCase)
    {
        "Title", "Author", "Keywords", "DocumentNumber", "Memo", "DocumentType", "Status", "Classification",
        "DocumentIndex", "Issue", "Version",
        "Text01", "Text02", "Text03", "Text04", "Text05", "Text06",
        "Text07", "Text08", "Text09", "Text10", "Text11", "Text12",
        "Date01", "Date02", "Date03", "Date04", "DocumentDate", "CreatedOn",
        "Boolean01", "Boolean02", "Boolean03",
        "Number01", "Number02", "Number03"
    };

    private static readonly HashSet<string> DateColumns = new(StringComparer.OrdinalIgnoreCase)
    {
        "Date01", "Date02", "Date03", "Date04", "DocumentDate", "CreatedOn"
    };

    private static readonly HashSet<string> BoolColumns = new(StringComparer.OrdinalIgnoreCase)
    {
        "Boolean01", "Boolean02", "Boolean03"
    };

    private static readonly HashSet<string> NumberColumns = new(StringComparer.OrdinalIgnoreCase)
    {
        "Number01", "Number02", "Number03"
    };

    private static void AppendStructuredFilters(StringBuilder sql, List<object> parameters, ExportFilterCriteria filters)
    {
        // Quick filters — multi-select IN clauses
        if (filters.Statuses.Count > 0)
        {
            var placeholders = string.Join(", ", filters.Statuses.Select((_, i) => $"{{{parameters.Count + i}}}"));
            sql.Append($" AND \"Status\" IN ({placeholders})");
            parameters.AddRange(filters.Statuses.Cast<object>());
        }

        if (filters.Classifications.Count > 0)
        {
            var placeholders = string.Join(", ", filters.Classifications.Select((_, i) => $"{{{parameters.Count + i}}}"));
            sql.Append($" AND \"Classification\" IN ({placeholders})");
            parameters.AddRange(filters.Classifications.Cast<object>());
        }

        if (filters.DocumentTypes.Count > 0)
        {
            var placeholders = string.Join(", ", filters.DocumentTypes.Select((_, i) => $"{{{parameters.Count + i}}}"));
            sql.Append($" AND \"DocumentType\" IN ({placeholders})");
            parameters.AddRange(filters.DocumentTypes.Cast<object>());
        }

        // Text search fields
        AppendLikeFilter(sql, parameters, "\"Title\"", filters.TitleContains);
        AppendLikeFilter(sql, parameters, "\"Author\"", filters.AuthorContains);
        AppendLikeFilter(sql, parameters, "\"Keywords\"", filters.KeywordsContains);
        AppendLikeFilter(sql, parameters, "\"DocumentNumber\"", filters.DocumentNumberContains);
        AppendLikeFilter(sql, parameters, "\"Memo\"", filters.MemoContains);

        // Date ranges
        if (filters.CreatedFrom.HasValue)
        {
            sql.Append($" AND \"CreatedOn\" >= {{{parameters.Count}}}");
            parameters.Add(filters.CreatedFrom.Value);
        }
        if (filters.CreatedTo.HasValue)
        {
            sql.Append($" AND \"CreatedOn\" <= {{{parameters.Count}}}");
            parameters.Add(filters.CreatedTo.Value.Date.AddDays(1).AddTicks(-1));
        }
        if (filters.DocumentDateFrom.HasValue)
        {
            sql.Append($" AND \"DocumentDate\" >= {{{parameters.Count}}}");
            parameters.Add(filters.DocumentDateFrom.Value);
        }
        if (filters.DocumentDateTo.HasValue)
        {
            sql.Append($" AND \"DocumentDate\" <= {{{parameters.Count}}}");
            parameters.Add(filters.DocumentDateTo.Value.Date.AddDays(1).AddTicks(-1));
        }

        // Custom field rules
        if (filters.FieldRules.Count > 0)
        {
            var ruleFragments = new List<string>();

            foreach (var rule in filters.FieldRules)
            {
                if (!AllowedColumns.Contains(rule.Field)) continue;
                if (string.IsNullOrWhiteSpace(rule.Value) && rule.Operator != "is_empty" && rule.Operator != "is_not_empty") continue;

                var fragment = BuildRuleFragment(rule, parameters);
                if (fragment != null)
                    ruleFragments.Add(fragment);
            }

            if (ruleFragments.Count > 0)
            {
                var logic = filters.RuleLogic == "OR" ? " OR " : " AND ";
                sql.Append($" AND ({string.Join(logic, ruleFragments)})");
            }
        }
    }

    private static void AppendLikeFilter(StringBuilder sql, List<object> parameters, string column, string? value)
    {
        if (string.IsNullOrWhiteSpace(value)) return;
        sql.Append($" AND {column} LIKE {{{parameters.Count}}}");
        parameters.Add($"%{value}%");
    }

    private static string? BuildRuleFragment(ExportFieldRule rule, List<object> parameters)
    {
        var col = $"\"{rule.Field}\"";

        switch (rule.Operator)
        {
            case "contains":
                parameters.Add($"%{rule.Value}%");
                return $"{col} LIKE {{{parameters.Count - 1}}}";

            case "equals":
                parameters.Add(rule.Value!);
                return $"{col} = {{{parameters.Count - 1}}}";

            case "not_equals":
                parameters.Add(rule.Value!);
                return $"({col} IS NULL OR {col} <> {{{parameters.Count - 1}}})";

            case "starts_with":
                parameters.Add($"{rule.Value}%");
                return $"{col} LIKE {{{parameters.Count - 1}}}";

            case "ends_with":
                parameters.Add($"%{rule.Value}");
                return $"{col} LIKE {{{parameters.Count - 1}}}";

            case "is_empty":
                return $"({col} IS NULL OR {col} = '')";

            case "is_not_empty":
                return $"({col} IS NOT NULL AND {col} <> '')";

            case "greater_than":
                if (DateColumns.Contains(rule.Field) && DateTime.TryParse(rule.Value, out var gtDate))
                {
                    parameters.Add(gtDate);
                    return $"{col} > {{{parameters.Count - 1}}}";
                }
                if (NumberColumns.Contains(rule.Field) && double.TryParse(rule.Value, out var gtNum))
                {
                    parameters.Add(gtNum);
                    return $"{col} > {{{parameters.Count - 1}}}";
                }
                return null;

            case "less_than":
                if (DateColumns.Contains(rule.Field) && DateTime.TryParse(rule.Value, out var ltDate))
                {
                    parameters.Add(ltDate);
                    return $"{col} < {{{parameters.Count - 1}}}";
                }
                if (NumberColumns.Contains(rule.Field) && double.TryParse(rule.Value, out var ltNum))
                {
                    parameters.Add(ltNum);
                    return $"{col} < {{{parameters.Count - 1}}}";
                }
                return null;

            case "is_true":
                return $"{col} = 1";

            case "is_false":
                return $"({col} IS NULL OR {col} = 0)";

            default:
                return null;
        }
    }

    private async Task<List<DocumentPage>> GetDocumentPagesAsync(
        AppDbContext context, string schemaName, int documentId, CancellationToken ct)
    {
        var sql = $"SELECT \"PageId\", \"DocumentId\", \"DocumentIndex\", \"PageNumber\", \"PageReference\", \"FrameNumber\", " +
                  $"\"Level1\", \"Level2\", \"Level3\", \"Level4\", \"DiskNumber\", \"FileName\", \"FilePath\", \"FileType\", " +
                  $"\"FileContent\", \"FileSize\", \"FileFormat\", \"PageSize\", \"ContentType\", \"UploadedDate\", \"ChecksumMD5\", " +
                  $"\"StorageType\", \"CreatedOn\", \"CreatedBy\", \"ModifiedOn\", \"ModifiedBy\" " +
                  $"FROM \"{schemaName}\".\"DocumentPage\" WHERE \"DocumentId\" = {{0}}";

        return await context.Database
            .SqlQueryRaw<DocumentPage>(sql, documentId)
            .ToListAsync(ct);
    }

    private static string BuildCsvRow(Document doc, string? fileName)
    {
        var fields = new[]
        {
            CsvEscape(fileName ?? ""),
            CsvEscape(doc.DocumentIndex),
            CsvEscape(doc.Title),
            CsvEscape(doc.Author),
            CsvEscape(doc.DocumentDate?.ToString("yyyy-MM-dd")),
            CsvEscape(doc.Keywords),
            CsvEscape(doc.Memo),
            CsvEscape(doc.Status),
            CsvEscape(doc.Classification),
            CsvEscape(doc.Version),
            CsvEscape(doc.Issue),
            CsvEscape(doc.Text01), CsvEscape(doc.Text02), CsvEscape(doc.Text03),
            CsvEscape(doc.Text04), CsvEscape(doc.Text05), CsvEscape(doc.Text06),
            CsvEscape(doc.Text07), CsvEscape(doc.Text08), CsvEscape(doc.Text09),
            CsvEscape(doc.Text10), CsvEscape(doc.Text11), CsvEscape(doc.Text12),
            CsvEscape(doc.Date01?.ToString("yyyy-MM-dd")),
            CsvEscape(doc.Date02?.ToString("yyyy-MM-dd")),
            CsvEscape(doc.Date03?.ToString("yyyy-MM-dd")),
            CsvEscape(doc.Date04?.ToString("yyyy-MM-dd")),
            CsvEscape(doc.Boolean01?.ToString()),
            CsvEscape(doc.Boolean02?.ToString()),
            CsvEscape(doc.Boolean03?.ToString()),
            CsvEscape(doc.Number01?.ToString()),
            CsvEscape(doc.Number02?.ToString()),
            CsvEscape(doc.Number03?.ToString())
        };
        return string.Join(",", fields);
    }

    private static string CsvEscape(string? value)
    {
        if (string.IsNullOrEmpty(value)) return "";
        if (value.Contains(',') || value.Contains('"') || value.Contains('\n') || value.Contains('\r'))
            return $"\"{value.Replace("\"", "\"\"")}\"";
        return value;
    }

    private static string GetUniqueFileName(string directory, string fileName)
    {
        if (string.IsNullOrEmpty(fileName))
            fileName = "unknown";

        var safeName = string.Join("_", fileName.Split(Path.GetInvalidFileNameChars()));
        var targetPath = Path.Combine(directory, safeName);

        if (!File.Exists(targetPath))
            return safeName;

        var nameWithoutExt = Path.GetFileNameWithoutExtension(safeName);
        var extension = Path.GetExtension(safeName);
        int counter = 1;

        while (File.Exists(Path.Combine(directory, $"{nameWithoutExt}_{counter}{extension}")))
            counter++;

        return $"{nameWithoutExt}_{counter}{extension}";
    }

    private static void CopyDirectory(string source, string target)
    {
        Directory.CreateDirectory(target);

        foreach (var file in Directory.GetFiles(source))
        {
            var destFile = Path.Combine(target, Path.GetFileName(file));
            File.Copy(file, destFile, overwrite: true);
        }

        foreach (var dir in Directory.GetDirectories(source))
        {
            var destDir = Path.Combine(target, Path.GetFileName(dir));
            CopyDirectory(dir, destDir);
        }
    }

    private async Task SendNotificationAsync(
        NotificationService notificationService, ExportWorkItem workItem, BulkExportJobStatus job)
    {
        try
        {
            string title, message;

            switch (job.Status)
            {
                case BulkExportStatuses.Completed:
                    title = "Bulk Export Complete";
                    var sizeMb = Math.Round(job.ExportSizeBytes / (1024.0 * 1024.0), 1);
                    message = $"Exported {job.ExportedDocuments} documents ({job.ExportedFiles} files, {sizeMb}MB) from {job.ProjectName}. Duration: {job.Elapsed.TotalSeconds:F1}s";
                    if (job.FailedFiles > 0)
                        message += $" ({job.FailedFiles} files failed)";
                    break;
                case BulkExportStatuses.Cancelled:
                    title = "Bulk Export Cancelled";
                    message = $"Export from {job.ProjectName} was cancelled. {job.ExportedDocuments}/{job.TotalDocuments} documents exported.";
                    break;
                case BulkExportStatuses.Failed:
                    title = "Bulk Export Failed";
                    message = $"Export from {job.ProjectName} failed: {job.Error}";
                    break;
                default:
                    return;
            }

            // Truncate message to 255 chars
            if (message.Length > 255)
                message = message[..252] + "...";

            await notificationService.CreateNotificationAsync(new CreateNotificationDto
            {
                UserId = workItem.UserId,
                Title = title,
                Message = message,
                Category = NotificationCategories.BatchExport,
                IsImportant = job.Status != BulkExportStatuses.Completed,
                SourceSystem = NotificationSources.Api
            });
        }
        catch (Exception ex)
        {
            _logger.LogWarning(ex, "Failed to send export notification for job {JobId}", job.JobId);
        }
    }
}

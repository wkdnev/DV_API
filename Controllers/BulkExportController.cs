using DV.API.Data;
using DV.API.Services;
using DV.Shared.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DV.API.Controllers;

/// <summary>
/// API Controller for bulk export operations.
/// Supports background export of documents and files to ZIP or folder output.
/// </summary>
[ApiController]
[Route("api/[controller]")]
[Authorize]
public class BulkExportController : ControllerBase
{
    private readonly IExportTaskQueue _taskQueue;
    private readonly DocumentRepository _repo;
    private readonly UserService _userService;
    private readonly AuditService _auditService;
    private readonly BulkExportService _exportService;
    private readonly ILogger<BulkExportController> _logger;

    public BulkExportController(
        IExportTaskQueue taskQueue,
        DocumentRepository repo,
        UserService userService,
        AuditService auditService,
        BulkExportService exportService,
        ILogger<BulkExportController> logger)
    {
        _taskQueue = taskQueue;
        _repo = repo;
        _userService = userService;
        _auditService = auditService;
        _exportService = exportService;
        _logger = logger;
    }

    /// <summary>
    /// Start a bulk export job. Returns immediately with a job ID for status polling.
    /// </summary>
    [HttpPost("start")]
    public async Task<ActionResult<BulkExportJobStatus>> StartExport([FromBody] BulkExportRequest request)
    {
        if (string.IsNullOrEmpty(request.SchemaName))
            return BadRequest(new { error = "SchemaName is required" });

        if (request.ProjectId <= 0)
            return BadRequest(new { error = "Valid ProjectId is required" });

        // Validate edit access
        var hasAccess = await _repo.HasProjectEditAccessAsync(User, request.ProjectId);
        if (!hasAccess)
            return Forbid();

        // Resolve user
        var userId = await GetCurrentUserIdAsync();
        if (userId == 0)
            return Unauthorized(new { error = "Could not resolve user identity" });

        var username = User.Identity?.Name ?? "Unknown";

        // Sanitize folder path if provided
        if (request.OutputFormat == "Folder" && !string.IsNullOrEmpty(request.OutputPath))
        {
            var fullPath = Path.GetFullPath(request.OutputPath);
            // Prevent path traversal
            if (!fullPath.StartsWith(request.OutputPath.TrimEnd(Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar), StringComparison.OrdinalIgnoreCase)
                && !Path.IsPathRooted(request.OutputPath))
            {
                return BadRequest(new { error = "Invalid output path" });
            }
            request.OutputPath = fullPath;
        }

        var jobId = Guid.NewGuid();
        var cts = new CancellationTokenSource();

        var job = new BulkExportJobStatus
        {
            JobId = jobId,
            SchemaName = request.SchemaName,
            ProjectId = request.ProjectId,
            OutputFormat = request.OutputFormat,
            UserId = userId,
            Status = BulkExportStatuses.Queued
        };

        BulkExportService.Jobs[jobId] = job;
        BulkExportService.CancellationSources[jobId] = cts;

        var workItem = new ExportWorkItem
        {
            JobId = jobId,
            Request = request,
            UserId = userId,
            Username = username,
            CancellationSource = cts
        };

        await _taskQueue.QueueAsync(workItem);

        _logger.LogInformation("Export job {JobId} queued by {User} for schema {Schema}",
            jobId, username, request.SchemaName);

        await _auditService.LogSecurityEventAsync(
            username, userId, "BULK_EXPORT_STARTED",
            $"Export started for project {request.ProjectId} ({request.SchemaName}), mode={request.ExportMode}, format={request.OutputFormat}");

        return Accepted(job);
    }

    /// <summary>
    /// Get the status of a bulk export job.
    /// </summary>
    [HttpGet("status/{jobId:guid}")]
    public ActionResult<BulkExportJobStatus> GetStatus(Guid jobId)
    {
        if (BulkExportService.Jobs.TryGetValue(jobId, out var job))
            return Ok(job);

        return NotFound(new { error = "Export job not found" });
    }

    /// <summary>
    /// Download the completed ZIP export file.
    /// </summary>
    [HttpGet("download/{jobId:guid}")]
    public ActionResult DownloadExport(Guid jobId)
    {
        if (!BulkExportService.Jobs.TryGetValue(jobId, out var job))
            return NotFound(new { error = "Export job not found" });

        if (job.Status != BulkExportStatuses.Completed)
            return BadRequest(new { error = $"Export is not complete (status: {job.Status})" });

        if (job.OutputFormat != "Zip" || string.IsNullOrEmpty(job.OutputPath))
            return BadRequest(new { error = "No downloadable file for folder exports" });

        if (!System.IO.File.Exists(job.OutputPath))
            return NotFound(new { error = "Export file has expired or been cleaned up" });

        var fileName = $"{job.ProjectName}_Export_{job.CompletedAt:yyyyMMdd_HHmmss}.zip";
        var sanitizedFileName = string.Join("_", fileName.Split(Path.GetInvalidFileNameChars()));
        var stream = new FileStream(job.OutputPath, FileMode.Open, FileAccess.Read, FileShare.Read);
        return File(stream, "application/zip", sanitizedFileName);
    }

    /// <summary>
    /// Cancel an in-progress export job.
    /// </summary>
    [HttpPost("cancel/{jobId:guid}")]
    public ActionResult CancelExport(Guid jobId)
    {
        if (!BulkExportService.Jobs.TryGetValue(jobId, out var job))
            return NotFound(new { error = "Export job not found" });

        if (job.Status != BulkExportStatuses.Queued && job.Status != BulkExportStatuses.Processing)
            return BadRequest(new { error = $"Cannot cancel job with status: {job.Status}" });

        if (BulkExportService.CancellationSources.TryGetValue(jobId, out var cts))
        {
            cts.Cancel();
            _logger.LogInformation("Export job {JobId} cancellation requested", jobId);
        }

        return Ok(new { message = "Cancellation requested" });
    }

    /// <summary>
    /// List all export jobs for the current user.
    /// </summary>
    [HttpGet("jobs")]
    public async Task<ActionResult<List<BulkExportJobStatus>>> ListJobs()
    {
        var userId = await GetCurrentUserIdAsync();
        var jobs = BulkExportService.Jobs.Values
            .Where(j => j.UserId == userId)
            .OrderByDescending(j => j.QueuedAt)
            .ToList();
        return Ok(jobs);
    }

    /// <summary>
    /// Preview count of documents matching filter criteria without starting an export.
    /// </summary>
    [HttpPost("preview-count")]
    public async Task<ActionResult> PreviewCount([FromBody] BulkExportRequest request)
    {
        if (string.IsNullOrEmpty(request.SchemaName) || request.ProjectId <= 0)
            return BadRequest(new { count = 0 });

        var hasAccess = await _repo.HasProjectEditAccessAsync(User, request.ProjectId);
        if (!hasAccess) return Forbid();

        try
        {
            var count = await _exportService.GetFilteredDocumentCountAsync(request);
            return Ok(new { count });
        }
        catch (Exception ex)
        {
            _logger.LogWarning(ex, "Preview count failed for schema {Schema}", request.SchemaName);
            return Ok(new { count = -1 });
        }
    }

    private async Task<int> GetCurrentUserIdAsync()
    {
        var username = User.Identity?.Name;
        if (string.IsNullOrEmpty(username)) return 0;

        var user = await _userService.GetUserByUsernameAsync(username);
        return user?.UserId ?? 0;
    }
}

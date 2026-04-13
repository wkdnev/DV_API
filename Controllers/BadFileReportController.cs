// ============================================================================
// BadFileReportController.cs - API Controller for Bad File Reports
// ============================================================================
//
// Purpose: Provides CRUD endpoints for bad file reports.
// ReadOnly and Editor users can create reports.
// Only Editors can update status/resolution fields.
// ============================================================================

using DV.Shared.DTOs;
using DV.Shared.Models;
using DV.API.Services;
using DV.API.Data;
using DV.Shared.Security;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace DV.API.Controllers;

[ApiController]
[Route("api/[controller]")]
[Authorize]
public class BadFileReportController : ControllerBase
{
    private readonly DocumentRepository _repo;
    private readonly UserService _userService;
    private readonly AuditService _auditService;
    private readonly NotificationService _notificationService;
    private readonly SecurityDbContext _securityContext;
    private readonly AppDbContext _appContext;

    public BadFileReportController(
        DocumentRepository repo,
        UserService userService,
        AuditService auditService,
        NotificationService notificationService,
        SecurityDbContext securityContext,
        AppDbContext appContext)
    {
        _repo = repo;
        _userService = userService;
        _auditService = auditService;
        _notificationService = notificationService;
        _securityContext = securityContext;
        _appContext = appContext;
    }

    // ── GET: api/BadFileReport?schemaName=X&status=Open&page=1&pageSize=20 ──
    [HttpGet]
    public async Task<ActionResult<BadFileReportListResponseDto>> GetReports(
        [FromQuery] string schemaName,
        [FromQuery] string? status = null,
        [FromQuery] string? reportType = null,
        [FromQuery] string? priority = null,
        [FromQuery] int page = 1,
        [FromQuery] int pageSize = 20)
    {
        if (string.IsNullOrWhiteSpace(schemaName))
            return BadRequest("schemaName is required.");

        var username = User.Identity?.Name;
        if (string.IsNullOrEmpty(username))
            return Unauthorized();

        try
        {
            var result = await GetReportsFromDb(schemaName, status, reportType, priority, page, pageSize);
            return Ok(result);
        }
        catch (Exception ex)
        {
            Console.Error.WriteLine($"BadFileReportController.GetReports error: {ex.Message}");
            return StatusCode(500, "Failed to retrieve reports.");
        }
    }

    // ── GET: api/BadFileReport/{schemaName}/{id} ──
    [HttpGet("{schemaName}/{id:int}")]
    public async Task<ActionResult<BadFileReportDto>> GetReport(string schemaName, int id)
    {
        var username = User.Identity?.Name;
        if (string.IsNullOrEmpty(username))
            return Unauthorized();

        try
        {
            var report = await GetReportFromDb(schemaName, id);
            if (report == null)
                return NotFound();
            return Ok(report);
        }
        catch (Exception ex)
        {
            Console.Error.WriteLine($"BadFileReportController.GetReport error: {ex.Message}");
            return StatusCode(500, "Failed to retrieve report.");
        }
    }

    // ── POST: api/BadFileReport ──
    [HttpPost]
    public async Task<ActionResult<BadFileReportDto>> CreateReport([FromBody] CreateBadFileReportDto request)
    {
        var username = User.Identity?.Name;
        if (string.IsNullOrEmpty(username))
            return Unauthorized();

        if (string.IsNullOrWhiteSpace(request.SchemaName))
            return BadRequest("SchemaName is required.");
        if (string.IsNullOrWhiteSpace(request.ReportType))
            return BadRequest("ReportType is required.");
        if (request.DocumentPageId <= 0)
            return BadRequest("DocumentPageId is required.");

        try
        {
            var user = await _userService.GetUserByUsernameAsync(username);
            if (user == null)
                return Unauthorized("User not found.");

            var reportId = await InsertReportToDb(request, user.UserId);
            var created = await GetReportFromDb(request.SchemaName, reportId);

            await _auditService.LogEventAsync(new AuditLog
            {
                UserId = user.UserId,
                Username = username,
                EventType = AuditEventTypes.BadFileReport,
                Action = AuditActions.CreateReport,
                Details = $"Created bad file report #{reportId} in schema {request.SchemaName}",
                IpAddress = HttpContext.Connection.RemoteIpAddress?.ToString(),
                Timestamp = DateTime.UtcNow
            });

            // Notify the submitting user
            await _notificationService.CreateNotificationAsync(new CreateNotificationDto
            {
                UserId = user.UserId,
                Title = "Bad File Report Submitted",
                Message = $"Your report #{reportId} for '{request.FileName ?? "unknown file"}' in {request.SchemaName} has been submitted.",
                Category = NotificationCategories.BadFileReport,
                SourceSystem = NotificationSources.Api,
                CorrelationId = $"bfr-{request.SchemaName}-{reportId}"
            });

            // Notify editors of the schema
            await NotifySchemaEditorsAsync(request.SchemaName, user.UserId,
                "New Bad File Report",
                $"Report #{reportId} submitted by {username} for '{request.FileName ?? "unknown file"}' ({request.ReportType}) in {request.SchemaName}.",
                $"bfr-{request.SchemaName}-{reportId}");

            return CreatedAtAction(nameof(GetReport),
                new { schemaName = request.SchemaName, id = reportId }, created);
        }
        catch (Exception ex)
        {
            Console.Error.WriteLine($"BadFileReportController.CreateReport error: {ex.Message}");
            return StatusCode(500, "Failed to create report.");
        }
    }

    // ── PUT: api/BadFileReport/{schemaName}/{id} ──
    // Editor-only: updates status, corrective action, resolution notes
    [HttpPut("{schemaName}/{id:int}")]
    public async Task<ActionResult<BadFileReportDto>> UpdateReport(
        string schemaName, int id, [FromBody] UpdateBadFileReportDto request)
    {
        var username = User.Identity?.Name;
        if (string.IsNullOrEmpty(username))
            return Unauthorized();

        try
        {
            var user = await _userService.GetUserByUsernameAsync(username);
            if (user == null)
                return Unauthorized("User not found.");

            var existing = await GetReportFromDb(schemaName, id);
            if (existing == null)
                return NotFound();

            await UpdateReportInDb(schemaName, id, request, user.UserId);
            var updated = await GetReportFromDb(schemaName, id);

            await _auditService.LogEventAsync(new AuditLog
            {
                UserId = user.UserId,
                Username = username,
                EventType = AuditEventTypes.BadFileReport,
                Action = AuditActions.UpdateReport,
                Details = $"Updated bad file report #{id} in schema {schemaName} (Status: {request.Status})",
                IpAddress = HttpContext.Connection.RemoteIpAddress?.ToString(),
                Timestamp = DateTime.UtcNow
            });

            // Notify the original reporter if status changed
            if (request.Status != null && existing.ReportedBy != user.UserId)
            {
                await _notificationService.CreateNotificationAsync(new CreateNotificationDto
                {
                    UserId = existing.ReportedBy,
                    Title = "Bad File Report Updated",
                    Message = $"Report #{id} for '{existing.FileName ?? "unknown file"}' in {schemaName} has been updated to '{request.Status}'.",
                    Category = NotificationCategories.BadFileReport,
                    SourceSystem = NotificationSources.Api,
                    CorrelationId = $"bfr-{schemaName}-{id}"
                });
            }

            return Ok(updated);
        }
        catch (Exception ex)
        {
            Console.Error.WriteLine($"BadFileReportController.UpdateReport error: {ex.Message}");
            return StatusCode(500, "Failed to update report.");
        }
    }

    // ========================================================================
    // Notification helpers
    // ========================================================================

    private async Task NotifySchemaEditorsAsync(string schemaName, int excludeUserId,
        string title, string message, string correlationId)
    {
        try
        {
            // Find projects with this schema
            var project = await _appContext.Projects
                .FirstOrDefaultAsync(p => p.SchemaName == schemaName);
            if (project == null || string.IsNullOrEmpty(project.EditPrincipal)) return;

            // Find the access group matching the EditPrincipal
            var group = await _securityContext.AccessGroups
                .FirstOrDefaultAsync(g => g.GroupName == project.EditPrincipal && g.IsActive);
            if (group == null) return;

            // Get group members
            var editorUserIds = await _securityContext.AccessGroupMembers
                .Where(m => m.AccessGroupId == group.AccessGroupId && m.UserId != excludeUserId)
                .Select(m => m.UserId)
                .ToListAsync();

            foreach (var editorUserId in editorUserIds)
            {
                await _notificationService.CreateNotificationAsync(new CreateNotificationDto
                {
                    UserId = editorUserId,
                    Title = title,
                    Message = message,
                    Category = NotificationCategories.BadFileReport,
                    SourceSystem = NotificationSources.Api,
                    CorrelationId = correlationId
                });
            }
        }
        catch (Exception ex)
        {
            // Don't fail the request if notifications fail
            Console.Error.WriteLine($"BadFileReportController: Error sending editor notifications: {ex.Message}");
        }
    }

    // ========================================================================
    // Private database methods using raw SQL (schema-aware)
    // ========================================================================

    private async Task<BadFileReportListResponseDto> GetReportsFromDb(
        string schemaName, string? status, string? reportType, string? priority, int page, int pageSize)
    {
        var context = _repo.GetDbContext();
        var connection = context.Database.GetDbConnection();
        await connection.OpenAsync();
        try
        {
            // Build WHERE clause with parameters
            var conditions = new List<string>();
            var paramList = new List<(string name, object value)>();

            if (!string.IsNullOrWhiteSpace(status))
            {
                conditions.Add("r.\"Status\" = @filterStatus");
                paramList.Add(("@filterStatus", status));
            }
            if (!string.IsNullOrWhiteSpace(reportType))
            {
                conditions.Add("r.\"ReportType\" = @filterReportType");
                paramList.Add(("@filterReportType", reportType));
            }
            if (!string.IsNullOrWhiteSpace(priority))
            {
                conditions.Add("r.\"Priority\" = @filterPriority");
                paramList.Add(("@filterPriority", priority));
            }

            var whereClause = conditions.Count > 0
                ? "WHERE " + string.Join(" AND ", conditions)
                : "";

            // Helper to create a command with shared parameters
            System.Data.Common.DbCommand CreateCmd(string sql)
            {
                var cmd = connection.CreateCommand();
                cmd.CommandText = sql;
                foreach (var (name, value) in paramList)
                {
                    var p = cmd.CreateParameter();
                    p.ParameterName = name;
                    p.Value = value;
                    cmd.Parameters.Add(p);
                }
                return cmd;
            }

            // Count query
            using var countCmd = CreateCmd($"SELECT COUNT(*) FROM \"{schemaName}\".\"BadFileReport\" r {whereClause}");
            var totalCount = Convert.ToInt32(await countCmd.ExecuteScalarAsync() ?? 0);

            // Status counts
            using var openCmd = CreateCmd($"SELECT COUNT(*) FROM \"{schemaName}\".\"BadFileReport\" r WHERE r.\"Status\" = 'Open'");
            var openCount = Convert.ToInt32(await openCmd.ExecuteScalarAsync() ?? 0);

            using var ipCmd = CreateCmd($"SELECT COUNT(*) FROM \"{schemaName}\".\"BadFileReport\" r WHERE r.\"Status\" = 'InProgress'");
            var inProgressCount = Convert.ToInt32(await ipCmd.ExecuteScalarAsync() ?? 0);

            using var resCmd = CreateCmd($"SELECT COUNT(*) FROM \"{schemaName}\".\"BadFileReport\" r WHERE r.\"Status\" IN ('Resolved', 'Closed')");
            var resolvedCount = Convert.ToInt32(await resCmd.ExecuteScalarAsync() ?? 0);

            // Data query with paging
            var offset = (page - 1) * pageSize;
            var dataSql = $@"
                SELECT r.""BadFileReportId"", r.""ReportedBy"", r.""ReportedOn"", r.""DocumentPageId"",
                       r.""DocumentId"", r.""SchemaName"", r.""FileName"", r.""PageNumber"",
                       r.""ReportType"", r.""Description"", r.""Priority"", r.""Status"",
                       r.""CorrectiveAction"", r.""ResolutionNotes"", r.""ResolvedBy"", r.""ResolvedOn"",
                       r.""CreatedOn"",
                       ru.""UserName"" AS ""ReportedByUsername"",
                       res.""UserName"" AS ""ResolvedByUsername""
                FROM ""{schemaName}"".""BadFileReport"" r
                LEFT JOIN ""dbo"".""ApplicationUser"" ru ON r.""ReportedBy"" = ru.""UserId""
                LEFT JOIN ""dbo"".""ApplicationUser"" res ON r.""ResolvedBy"" = res.""UserId""
                {whereClause}
                ORDER BY r.""ReportedOn"" DESC
                LIMIT @pageSize OFFSET @offset";

            using var dataCmd = CreateCmd(dataSql);
            var offsetParam = dataCmd.CreateParameter();
            offsetParam.ParameterName = "@offset";
            offsetParam.Value = offset;
            dataCmd.Parameters.Add(offsetParam);
            var pageSizeParam = dataCmd.CreateParameter();
            pageSizeParam.ParameterName = "@pageSize";
            pageSizeParam.Value = pageSize;
            dataCmd.Parameters.Add(pageSizeParam);

            var dtos = new List<BadFileReportDto>();
            using var reader = await dataCmd.ExecuteReaderAsync();
            while (await reader.ReadAsync())
            {
                dtos.Add(new BadFileReportDto
                {
                    BadFileReportId = reader.GetInt32(reader.GetOrdinal("BadFileReportId")),
                    ReportedBy = reader.GetInt32(reader.GetOrdinal("ReportedBy")),
                    ReportedOn = reader.GetDateTime(reader.GetOrdinal("ReportedOn")),
                    DocumentPageId = reader.GetInt32(reader.GetOrdinal("DocumentPageId")),
                    DocumentId = reader.GetInt32(reader.GetOrdinal("DocumentId")),
                    SchemaName = reader.IsDBNull(reader.GetOrdinal("SchemaName")) ? schemaName : reader.GetString(reader.GetOrdinal("SchemaName")),
                    FileName = reader.IsDBNull(reader.GetOrdinal("FileName")) ? null : reader.GetString(reader.GetOrdinal("FileName")),
                    PageNumber = reader.GetInt32(reader.GetOrdinal("PageNumber")),
                    ReportType = reader.GetString(reader.GetOrdinal("ReportType")),
                    Description = reader.IsDBNull(reader.GetOrdinal("Description")) ? null : reader.GetString(reader.GetOrdinal("Description")),
                    Priority = reader.IsDBNull(reader.GetOrdinal("Priority")) ? "Normal" : reader.GetString(reader.GetOrdinal("Priority")),
                    Status = reader.IsDBNull(reader.GetOrdinal("Status")) ? "Open" : reader.GetString(reader.GetOrdinal("Status")),
                    CorrectiveAction = reader.IsDBNull(reader.GetOrdinal("CorrectiveAction")) ? null : reader.GetString(reader.GetOrdinal("CorrectiveAction")),
                    ResolutionNotes = reader.IsDBNull(reader.GetOrdinal("ResolutionNotes")) ? null : reader.GetString(reader.GetOrdinal("ResolutionNotes")),
                    ResolvedBy = reader.IsDBNull(reader.GetOrdinal("ResolvedBy")) ? null : reader.GetInt32(reader.GetOrdinal("ResolvedBy")),
                    ResolvedOn = reader.IsDBNull(reader.GetOrdinal("ResolvedOn")) ? null : reader.GetDateTime(reader.GetOrdinal("ResolvedOn")),
                    CreatedOn = reader.GetDateTime(reader.GetOrdinal("CreatedOn")),
                    ReportedByUsername = reader.IsDBNull(reader.GetOrdinal("ReportedByUsername")) ? null : reader.GetString(reader.GetOrdinal("ReportedByUsername")),
                    ResolvedByUsername = reader.IsDBNull(reader.GetOrdinal("ResolvedByUsername")) ? null : reader.GetString(reader.GetOrdinal("ResolvedByUsername")),
                });
            }

            return new BadFileReportListResponseDto
            {
                Reports = dtos,
                TotalCount = totalCount,
                Page = page,
                PageSize = pageSize,
                TotalPages = (int)Math.Ceiling(totalCount / (double)pageSize),
                OpenCount = openCount,
                InProgressCount = inProgressCount,
                ResolvedCount = resolvedCount
            };
        }
        finally
        {
            await connection.CloseAsync();
        }
    }

    private async Task<BadFileReportDto?> GetReportFromDb(string schemaName, int id)
    {
        var context = _repo.GetDbContext();
        var connection = context.Database.GetDbConnection();
        await connection.OpenAsync();
        try
        {
            var sql = $@"
                SELECT r.""BadFileReportId"", r.""ReportedBy"", r.""ReportedOn"", r.""DocumentPageId"",
                       r.""DocumentId"", r.""SchemaName"", r.""FileName"", r.""PageNumber"",
                       r.""ReportType"", r.""Description"", r.""Priority"", r.""Status"",
                       r.""CorrectiveAction"", r.""ResolutionNotes"", r.""ResolvedBy"", r.""ResolvedOn"",
                       r.""CreatedOn"",
                       ru.""UserName"" AS ""ReportedByUsername"",
                       res.""UserName"" AS ""ResolvedByUsername""
                FROM ""{schemaName}"".""BadFileReport"" r
                LEFT JOIN ""dbo"".""ApplicationUser"" ru ON r.""ReportedBy"" = ru.""UserId""
                LEFT JOIN ""dbo"".""ApplicationUser"" res ON r.""ResolvedBy"" = res.""UserId""
                WHERE r.""BadFileReportId"" = @id";

            using var cmd = connection.CreateCommand();
            cmd.CommandText = sql;
            var param = cmd.CreateParameter();
            param.ParameterName = "@id";
            param.Value = id;
            cmd.Parameters.Add(param);

            using var reader = await cmd.ExecuteReaderAsync();
            if (!await reader.ReadAsync()) return null;

            return new BadFileReportDto
            {
                BadFileReportId = reader.GetInt32(reader.GetOrdinal("BadFileReportId")),
                ReportedBy = reader.GetInt32(reader.GetOrdinal("ReportedBy")),
                ReportedByUsername = reader.IsDBNull(reader.GetOrdinal("ReportedByUsername")) ? null : reader.GetString(reader.GetOrdinal("ReportedByUsername")),
                ReportedOn = reader.GetDateTime(reader.GetOrdinal("ReportedOn")),
                DocumentPageId = reader.GetInt32(reader.GetOrdinal("DocumentPageId")),
                DocumentId = reader.GetInt32(reader.GetOrdinal("DocumentId")),
                SchemaName = reader.IsDBNull(reader.GetOrdinal("SchemaName")) ? schemaName : reader.GetString(reader.GetOrdinal("SchemaName")),
                FileName = reader.IsDBNull(reader.GetOrdinal("FileName")) ? null : reader.GetString(reader.GetOrdinal("FileName")),
                PageNumber = reader.GetInt32(reader.GetOrdinal("PageNumber")),
                ReportType = reader.GetString(reader.GetOrdinal("ReportType")),
                Description = reader.IsDBNull(reader.GetOrdinal("Description")) ? null : reader.GetString(reader.GetOrdinal("Description")),
                Priority = reader.IsDBNull(reader.GetOrdinal("Priority")) ? "Normal" : reader.GetString(reader.GetOrdinal("Priority")),
                Status = reader.IsDBNull(reader.GetOrdinal("Status")) ? "Open" : reader.GetString(reader.GetOrdinal("Status")),
                CorrectiveAction = reader.IsDBNull(reader.GetOrdinal("CorrectiveAction")) ? null : reader.GetString(reader.GetOrdinal("CorrectiveAction")),
                ResolutionNotes = reader.IsDBNull(reader.GetOrdinal("ResolutionNotes")) ? null : reader.GetString(reader.GetOrdinal("ResolutionNotes")),
                ResolvedBy = reader.IsDBNull(reader.GetOrdinal("ResolvedBy")) ? null : reader.GetInt32(reader.GetOrdinal("ResolvedBy")),
                ResolvedByUsername = reader.IsDBNull(reader.GetOrdinal("ResolvedByUsername")) ? null : reader.GetString(reader.GetOrdinal("ResolvedByUsername")),
                ResolvedOn = reader.IsDBNull(reader.GetOrdinal("ResolvedOn")) ? null : reader.GetDateTime(reader.GetOrdinal("ResolvedOn")),
                CreatedOn = reader.GetDateTime(reader.GetOrdinal("CreatedOn")),
            };
        }
        finally
        {
            await connection.CloseAsync();
        }
    }

    private async Task<int> InsertReportToDb(CreateBadFileReportDto request, int userId)
    {
        var context = _repo.GetDbContext();
        var sql = $@"
            INSERT INTO ""{request.SchemaName}"".""BadFileReport""
                (""ReportedBy"", ""DocumentPageId"", ""DocumentId"", ""SchemaName"", ""FileName"", ""PageNumber"",
                 ""ReportType"", ""Description"", ""Priority"", ""Status"", ""ImageUrl"",
                 ""UpdatedBy"", ""CreatedBy"")
            VALUES
                (@p0, @p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8, 'Open', @p9, @p0, @p0)
            RETURNING ""BadFileReportId""";

        var connection = context.Database.GetDbConnection();
        await connection.OpenAsync();
        try
        {
            using var command = connection.CreateCommand();
            command.CommandText = sql;

            var parameters = new (string name, object value)[]
            {
                ("@p0", userId),
                ("@p1", request.DocumentPageId),
                ("@p2", request.DocumentId),
                ("@p3", request.SchemaName),
                ("@p4", (object?)request.FileName ?? DBNull.Value),
                ("@p5", request.PageNumber),
                ("@p6", request.ReportType),
                ("@p7", (object?)request.Description ?? DBNull.Value),
                ("@p8", (object?)request.Priority ?? "Normal"),
                ("@p9", (object?)request.ImageUrl ?? DBNull.Value),
            };

            foreach (var (name, value) in parameters)
            {
                var param = command.CreateParameter();
                param.ParameterName = name;
                param.Value = value;
                command.Parameters.Add(param);
            }

            var result = await command.ExecuteScalarAsync();
            return result != null ? Convert.ToInt32(result) : 0;
        }
        finally
        {
            await connection.CloseAsync();
        }
    }

    private async Task UpdateReportInDb(string schemaName, int id, UpdateBadFileReportDto request, int userId)
    {
        var context = _repo.GetDbContext();

        var setClauses = new List<string>();
        var parameters = new List<object>();
        int paramIndex = 0;

        setClauses.Add($"\"ModifiedOn\" = NOW() AT TIME ZONE 'UTC'");
        setClauses.Add($"\"ModifiedBy\" = {{{paramIndex}}}");
        parameters.Add(userId);
        paramIndex++;

        setClauses.Add($"\"UpdatedBy\" = {{{paramIndex}}}");
        parameters.Add(userId);
        paramIndex++;

        if (request.Status != null)
        {
            setClauses.Add($"\"Status\" = {{{paramIndex}}}");
            parameters.Add(request.Status);
            paramIndex++;

            // Auto-set ResolvedBy/ResolvedOn when status becomes Resolved or Closed
            if (request.Status is "Resolved" or "Closed")
            {
                setClauses.Add($"\"ResolvedBy\" = {{{paramIndex}}}");
                parameters.Add(userId);
                paramIndex++;

                setClauses.Add("\"ResolvedOn\" = NOW() AT TIME ZONE 'UTC'");
            }
        }

        if (request.CorrectiveAction != null)
        {
            setClauses.Add($"\"CorrectiveAction\" = {{{paramIndex}}}");
            parameters.Add(request.CorrectiveAction);
            paramIndex++;
        }

        if (request.ResolutionNotes != null)
        {
            setClauses.Add($"\"ResolutionNotes\" = {{{paramIndex}}}");
            parameters.Add(request.ResolutionNotes);
            paramIndex++;
        }

        // Add the report ID as the last parameter
        var setClause = string.Join(", ", setClauses);
        var sql = $"UPDATE \"{schemaName}\".\"BadFileReport\" SET {setClause} WHERE \"BadFileReportId\" = {{{paramIndex}}}";
        parameters.Add(id);

        await context.Database.ExecuteSqlRawAsync(sql, parameters.ToArray());
    }

}

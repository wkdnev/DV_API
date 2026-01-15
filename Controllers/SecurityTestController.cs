using Microsoft.AspNetCore.Mvc;
using DV.API.Services;
using DV.Shared.Security;
using DV.API.Infrastructure.Caching;
using Microsoft.AspNetCore.Authorization;

namespace DV.API.Controllers;

[ApiController]
[Route("api/[controller]")]
[Authorize]
public class SecurityTestController : ControllerBase
{
    private readonly UserService _userService;
    private readonly UserProjectAccessService _userProjectAccessService;
    private readonly DocumentRepository _documentRepository;
    private readonly ICacheService _cache;
    private readonly ILogger<SecurityTestController> _logger;

    public SecurityTestController(
        UserService userService,
        UserProjectAccessService userProjectAccessService,
        DocumentRepository documentRepository,
        ICacheService cache,
        ILogger<SecurityTestController> logger)
    {
        _userService = userService;
        _userProjectAccessService = userProjectAccessService;
        _documentRepository = documentRepository;
        _cache = cache;
        _logger = logger;
    }

    /// <summary>
    /// Test endpoint to verify project access validation is working correctly
    /// </summary>
    [HttpGet("test-project-access/{documentId:int}")]
    public async Task<IActionResult> TestProjectAccess(int documentId)
    {
        try
        {
            var username = User.Identity?.Name;
            if (string.IsNullOrEmpty(username))
            {
                return Unauthorized("No username found");
            }

            // Get user from database
            var currentUser = await _userService.GetUserByUsernameAsync(username);
            if (currentUser == null)
            {
                return NotFound("User not found in system");
            }

            // Get document to check project access
            var document = await _documentRepository.GetDocumentAsync("DefaultConnection", documentId);
            if (document == null)
            {
                return NotFound("Document not found");
            }

            // Check if user is global admin
            var userRoles = await _userService.GetUserRolesAsync(currentUser.UserId);
            var isGlobalAdmin = userRoles.Any(r => r.Name == "Admin");

            // Check project access
            var hasAccess = isGlobalAdmin || (document.ProjectId.HasValue && await _userProjectAccessService.UserHasProjectAccessAsync(currentUser.UserId, document.ProjectId.Value));

            // Get accessible projects for user
            var accessibleProjects = await _userProjectAccessService.GetUserAccessibleProjectsAsync(currentUser.UserId);

            return Ok(new
            {
                Username = username,
                UserId = currentUser.UserId,
                DocumentId = documentId,
                DocumentTitle = document.Title,
                ProjectId = document.ProjectId,
                IsGlobalAdmin = isGlobalAdmin,
                HasProjectAccess = hasAccess,
                AccessibleProjectsCount = accessibleProjects.Count,
                AccessibleProjects = accessibleProjects.Select(p => new { p.ProjectId, p.ProjectName }),
                UserRoles = userRoles.Select(r => r.Name),
                CanAccessDocument = hasAccess,
                Message = hasAccess ? "User can access this document" : "User CANNOT access this document - project access denied"
            });
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error testing project access for document {DocumentId}", documentId);
            return StatusCode(500, new { Error = ex.Message });
        }
    }

    /// <summary>
    /// Test endpoint to list all projects and access status for current user
    /// </summary>
    [HttpGet("test-all-projects")]
    public async Task<IActionResult> TestAllProjects()
    {
        try
        {
            var username = User.Identity?.Name;
            if (string.IsNullOrEmpty(username))
            {
                return Unauthorized("No username found");
            }

            var currentUser = await _userService.GetUserByUsernameAsync(username);
            if (currentUser == null)
            {
                return NotFound("User not found in system");
            }

            // Get all projects
            var allProjects = await _documentRepository.GetProjectsAsync("DefaultConnection");
            
            // Check access for each project
            var userRoles = await _userService.GetUserRolesAsync(currentUser.UserId);
            var isGlobalAdmin = userRoles.Any(r => r.Name == "Admin");

            var projectAccessResults = new List<object>();

            foreach (var project in allProjects)
            {
                var hasAccess = isGlobalAdmin || await _userProjectAccessService.UserHasProjectAccessAsync(currentUser.UserId, project.ProjectId);
                
                projectAccessResults.Add(new
                {
                    ProjectId = project.ProjectId,
                    ProjectName = project.ProjectName,
                    SchemaName = project.SchemaName,
                    HasAccess = hasAccess,
                    AccessReason = isGlobalAdmin ? "Global Admin" : (hasAccess ? "Project Access Granted" : "No Project Access")
                });
            }

            return Ok(new
            {
                Username = username,
                UserId = currentUser.UserId,
                IsGlobalAdmin = isGlobalAdmin,
                UserRoles = userRoles.Select(r => r.Name),
                TotalProjects = allProjects.Count(),
                AccessibleProjects = projectAccessResults.Count(p => (bool)p.GetType().GetProperty("HasAccess")!.GetValue(p)!),
                ProjectAccess = projectAccessResults
            });
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error testing all projects access");
            return StatusCode(500, new { Error = ex.Message });
        }
    }

    /// <summary>
    /// Test endpoint for rate limiting - should be limited to 100 requests per minute
    /// </summary>
    [HttpGet("rate-limit-test")]
    public ActionResult<object> RateLimitTest()
    {
        var clientIp = HttpContext.Connection.RemoteIpAddress?.ToString() ?? "unknown";
        var timestamp = DateTime.UtcNow;
        
        _logger.LogInformation("Rate limit test called from IP: {ClientIp} at {Timestamp}", clientIp, timestamp);
        
        return Ok(new
        {
            Message = "Rate limit test successful",
            ClientIp = clientIp,
            Timestamp = timestamp,
            Headers = Response.Headers.Where(h => h.Key.StartsWith("X-RateLimit")).ToDictionary(h => h.Key, h => h.Value.ToString())
        });
    }

    /// <summary>
    /// Test endpoint for security headers verification
    /// </summary>
    [HttpGet("security-headers-test")]
    public ActionResult<object> SecurityHeadersTest()
    {
        _logger.LogInformation("Security headers test called");
        
        return Ok(new
        {
            Message = "Security headers test successful",
            ResponseHeaders = Response.Headers.ToDictionary(h => h.Key, h => h.Value.ToString()),
            RequestHeaders = Request.Headers.ToDictionary(h => h.Key, h => h.Value.ToString())
        });
    }

    /// <summary>
    /// Test endpoint for request/response logging
    /// </summary>
    [HttpPost("logging-test")]
    public ActionResult<object> LoggingTest([FromBody] TestRequest request)
    {
        _logger.LogInformation("Logging test called with data: {@Request}", request);
        
        return Ok(new
        {
            Message = "Logging test successful",
            ReceivedData = request,
            ProcessedAt = DateTime.UtcNow
        });
    }

    /// <summary>
    /// Test endpoint for cache functionality
    /// </summary>
    [HttpGet("cache-test")]
    public async Task<ActionResult<object>> CacheTest()
    {
        var cacheKey = "test:cache:endpoint";
        var timestamp = DateTime.UtcNow;
        
        // Test cache get/set functionality
        var cachedValue = await _cache.GetOrSetAsync(cacheKey, async () =>
        {
            _logger.LogInformation("Cache miss - generating new value");
            await Task.Delay(100); // Simulate some work
            return new { GeneratedAt = timestamp, Value = Guid.NewGuid().ToString() };
        }, TimeSpan.FromMinutes(5));

        var cacheStats = await _cache.GetStatisticsAsync();
        
        return Ok(new
        {
            Message = "Cache test successful",
            CachedValue = cachedValue,
            CacheStatistics = cacheStats,
            TestTimestamp = timestamp
        });
    }

    /// <summary>
    /// Health check endpoint (should be exempt from rate limiting)
    /// </summary>
    [HttpGet("health")]
    [AllowAnonymous]
    public ActionResult<object> Health()
    {
        return Ok(new
        {
            Status = "Healthy",
            Timestamp = DateTime.UtcNow,
            Environment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT"),
            Message = "Security test controller is operational"
        });
    }
}

/// <summary>
/// Test request model for logging test
/// </summary>
public class TestRequest
{
    public string? Message { get; set; }
    public int Number { get; set; }
    public DateTime Timestamp { get; set; } = DateTime.UtcNow;
}

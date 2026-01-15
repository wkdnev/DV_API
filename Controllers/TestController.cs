using DV.API.Data;
using Microsoft.AspNetCore.Mvc;
using DV.API.Services;
using DV.Shared.Security;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;

namespace DV.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TestController : ControllerBase
{
    private readonly UserService _userService;
    private readonly RoleContextService _roleContext;
    private readonly ILogger<TestController> _logger;

    public TestController(UserService userService, RoleContextService roleContext, ILogger<TestController> logger)
    {
        _userService = userService;
        _roleContext = roleContext;
        _logger = logger;
    }

    [HttpGet("auth")]
    public IActionResult TestAuth()
    {
        try
        {
            var username = User.Identity?.Name ?? "Unknown";
            var isAuthenticated = User.Identity?.IsAuthenticated ?? false;
            
            _logger.LogInformation("Test endpoint called by user: {Username}, Authenticated: {IsAuthenticated}", username, isAuthenticated);
            
            return Ok(new
            {
                IsAuthenticated = isAuthenticated,
                Username = username,
                Claims = User.Claims.Select(c => new { c.Type, c.Value }).ToList()
            });
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error in test auth endpoint");
            return StatusCode(500, new { Error = ex.Message });
        }
    }

    [HttpGet("user-roles")]
    [Authorize]
    public async Task<IActionResult> TestUserRoles()
    {
        try
        {
            var username = User.Identity?.Name ?? "Unknown";
            _logger.LogInformation("Testing user roles for: {Username}", username);
            
            // Get user from database
            var user = await _userService.GetUserByUsernameAsync(username);
            if (user == null)
            {
                _logger.LogWarning("User not found in database: {Username}", username);
                
                // Try to create the user
                var displayName = username.Contains('\\') ? username.Split('\\')[1] : username;
                user = await _userService.EnsureUserExistsAsync(username, displayName, $"{displayName}@example.com");
                _logger.LogInformation("Created user: {Username} with ID: {UserId}", username, user.UserId);
            }
            
            // Get user roles
            var roles = await _userService.GetUserRolesAsync(user.UserId);
            _logger.LogInformation("Found {RoleCount} roles for user {Username}", roles.Count, username);
            
            return Ok(new
            {
                Username = username,
                UserId = user.UserId,
                DisplayName = user.DisplayName,
                IsActive = user.IsActive,
                RoleCount = roles.Count,
                Roles = roles.Select(r => new { r.RoleId, r.Name, r.Description }).ToList()
            });
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error in test user roles endpoint");
            return StatusCode(500, new { Error = ex.Message, StackTrace = ex.StackTrace });
        }
    }

    [HttpGet("role-context")]
    [Authorize]
    public async Task<IActionResult> TestRoleContext()
    {
        try
        {
            var username = User.Identity?.Name ?? "Unknown";
            _logger.LogInformation("Testing role context for: {Username}", username);
            
            // Initialize role context
            var initialized = await _roleContext.InitializeAsync();
            
            return Ok(new
            {
                Username = username,
                Initialized = initialized,
                CurrentUsername = _roleContext.CurrentUsername,
                CurrentRole = _roleContext.CurrentRole?.Name,
                UserRolesCount = _roleContext.UserRoles.Count,
                HasMultipleRoles = _roleContext.HasMultipleRoles,
                UserRoles = _roleContext.UserRoles.Select(r => new { r.RoleId, r.Name }).ToList()
            });
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error in test role context endpoint");
            return StatusCode(500, new { Error = ex.Message, StackTrace = ex.StackTrace });
        }
    }

    // COMMENTED OUT: DebugSqlQueries method - deprecated UserRole functionality removed
    // This method tested the deprecated UserRole table which has been removed
    /*
    [HttpGet("debug-sql")]
    [Authorize]
    public async Task<IActionResult> DebugSqlQueries()
    {
        try
        {
            var username = User.Identity?.Name ?? "Unknown";
            _logger.LogInformation("Debugging SQL queries for user: {Username}", username);
            
            // Get user from database with logging
            var user = await _userService.GetUserByUsernameAsync(username);
            if (user == null)
            {
                return Ok(new { Error = "User not found", Username = username });
            }
            
            _logger.LogInformation("Found user: {UserId} - {Username}", user.UserId, user.Username);
            
            // Test the role query directly
            using var scope = HttpContext.RequestServices.CreateScope();
            var securityContext = scope.ServiceProvider.GetRequiredService<SecurityDbContext>();
            
            // Enable query logging
            var logger = scope.ServiceProvider.GetRequiredService<ILogger<SecurityDbContext>>();
            
            // Test 1: Check if UserRoles table exists and query works
            var userRoleRecords = await securityContext.UserRoles
                .Where(ur => ur.UserId == user.UserId)
                .ToListAsync();
            
            _logger.LogInformation("Found {Count} UserRole records for user {UserId}", userRoleRecords.Count, user.UserId);
            
            // Test 2: Try the full join query
            var roleQuery = from ur in securityContext.UserRoles
                           join r in securityContext.Roles on ur.RoleId equals r.RoleId
                           where ur.UserId == user.UserId
                           select r;
                           
            var roles = await roleQuery.ToListAsync();
            
            _logger.LogInformation("Found {Count} roles via join for user {UserId}", roles.Count, user.UserId);
            
            // Test 3: Check what tables EF thinks exist  
            var userTableName = securityContext.Model.FindEntityType(typeof(ApplicationUser))?.GetSchemaQualifiedTableName();
            var roleTableName = securityContext.Model.FindEntityType(typeof(ApplicationRole))?.GetSchemaQualifiedTableName();
            var userRoleTableName = securityContext.Model.FindEntityType(typeof(UserRole))?.GetSchemaQualifiedTableName();
            
            return Ok(new
            {
                Username = username,
                UserId = user.UserId,
                UserRoleRecords = userRoleRecords.Select(ur => new { ur.UserId, ur.RoleId }),
                Roles = roles.Select(r => new { r.RoleId, r.Name }),
                TableMappings = new
                {
                    UserTable = userTableName,
                    RoleTable = roleTableName,
                    UserRoleTable = userRoleTableName
                },
                QueryResults = new
                {
                    UserRoleCount = userRoleRecords.Count,
                    RoleCount = roles.Count
                }
            });
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error in debug SQL endpoint");
            return StatusCode(500, new { Error = ex.Message, StackTrace = ex.StackTrace });
        }
    }
    */
}


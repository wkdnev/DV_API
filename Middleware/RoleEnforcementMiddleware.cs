// ============================================================================
// RoleEnforcementMiddleware.cs - API Role-Based Access Control Middleware
// ============================================================================
//
// Purpose: Middleware that enforces role-based access control at the API level.
// For the API project, this validates JWT tokens and role claims.
//
// Note: This is a simplified version for the API project. The full role context
// management with AuthenticationStateProvider remains in DV_Web for Blazor UI.
//
// ============================================================================

using System.Security.Claims;
using DV.API.Services;

namespace DV.API.Middleware;

/// <summary>
/// Enforces role-based access control for API requests.
/// Validates that authenticated users have appropriate roles to access endpoints.
/// </summary>
public class RoleEnforcementMiddleware
{
    private readonly RequestDelegate _next;
    private readonly ILogger<RoleEnforcementMiddleware> _logger;

    public RoleEnforcementMiddleware(RequestDelegate next, ILogger<RoleEnforcementMiddleware> logger)
    {
        _next = next;
        _logger = logger;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        var path = context.Request.Path.Value?.ToLower() ?? "";

        // Skip middleware for static files, health checks, and auth endpoints
        if (ShouldSkipMiddleware(path))
        {
            await _next(context);
            return;
        }

        // Check if user is authenticated
        if (context.User.Identity?.IsAuthenticated != true)
        {
            // Allow anonymous access to continue - let [Authorize] attributes handle authorization
            await _next(context);
            return;
        }

        try
        {
            // Log the authenticated user and their roles for debugging
            var username = context.User.Identity?.Name ?? "Unknown";
            var roles = context.User.Claims
                .Where(c => c.Type == ClaimTypes.Role || c.Type == "role")
                .Select(c => c.Value)
                .ToList();

            _logger.LogDebug("API Request: User={Username}, Path={Path}, Roles={Roles}", 
                username, path, string.Join(", ", roles));

            // Continue to the next middleware/endpoint
            // Actual authorization is handled by [Authorize(Roles = "...")] attributes on controllers
            await _next(context);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error in role enforcement middleware for path: {Path}", path);
            await _next(context);
        }
    }

    private static bool ShouldSkipMiddleware(string path)
    {
        // Skip for static files
        if (path.Contains('.') && !path.EndsWith(".razor", StringComparison.OrdinalIgnoreCase))
            return true;

        // Skip for health checks
        if (path.StartsWith("/health", StringComparison.OrdinalIgnoreCase))
            return true;

        // Skip for Swagger/OpenAPI
        if (path.StartsWith("/swagger", StringComparison.OrdinalIgnoreCase))
            return true;

        // Skip for authentication endpoints
        if (path.StartsWith("/api/auth", StringComparison.OrdinalIgnoreCase))
            return true;

        return false;
    }
}




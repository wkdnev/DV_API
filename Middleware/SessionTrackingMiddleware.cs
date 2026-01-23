using DV.API.Services;

namespace DV.API.Middleware;

/// <summary>
/// Middleware to automatically track user sessions and activity
/// </summary>
public class SessionTrackingMiddleware
{
    private readonly RequestDelegate _next;
    private readonly ILogger<SessionTrackingMiddleware> _logger;

    public SessionTrackingMiddleware(RequestDelegate next, ILogger<SessionTrackingMiddleware> logger)
    {
        _next = next;
        _logger = logger;
    }

    public async Task InvokeAsync(HttpContext context, SessionManagementService sessionService, UserService userService)
    {
        try
        {
            // Only track authenticated users
            if (context.User.Identity?.IsAuthenticated == true)
            {
                var username = context.User.Identity.Name;
                if (!string.IsNullOrEmpty(username))
                {
                    // Track ALL authenticated activity, including API calls
                    // This is critical for session management dashboard
                    if (context.Request.Path.HasValue && 
                        !context.Request.Path.Value.StartsWith("/_blazor") &&
                        !context.Request.Path.Value.StartsWith("/_content") &&
                        !context.Request.Path.Value.Contains(".")) // Skip static files
                    {
                        // Ensure session exists (lazy loading)
                        // Because OIDC doesn't guarantee a session record exists in our DB until we create it
                        // We do this check/create logic here lightly, or rely on InitialiseSessionAsync having logic.
                        
                        await sessionService.InitializeSessionAsync(username, null, null);

                        await sessionService.UpdateSessionActivityAsync(
                            "Activity", 
                            context.Request.Method,
                            context.Request.Path.Value);
                    }
                }
            }
        }
        catch (Exception ex)
        {
            // Session tracking should not break the application
            _logger.LogWarning(ex, "Error in session tracking middleware");
        }

        await _next(context);
    }
}


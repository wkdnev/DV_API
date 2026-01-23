using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using DV.API.Services;
using DV.Shared.Constants;
using DV.Shared.Security;
using System.Security.Claims;

namespace DV.API.Controllers;

[Route("api/[controller]")]
[ApiController]
[Authorize]
public class SessionController : ControllerBase
{
    private readonly SessionManagementService _sessionService;
    private readonly UserService _userService;
    private readonly ILogger<SessionController> _logger;

    public SessionController(
        SessionManagementService sessionService,
        UserService userService,
        ILogger<SessionController> logger)
    {
        _sessionService = sessionService;
        _userService = userService;
        _logger = logger;
    }

    /// <summary>
    /// Gets all active sessions. Requires Global Admin.
    /// </summary>
    [HttpGet]
    [Authorize(Policy = "RequireGlobalAdmin")]
    public async Task<ActionResult<List<UserSession>>> GetActiveSessions()
    {
        var sessions = await _sessionService.GetActiveSessionsAsync();
        return Ok(sessions);
    }

    /// <summary>
    /// Gets specific session details
    /// </summary>
    [HttpGet("{id}")]
    [Authorize(Policy = "RequireGlobalAdmin")]
    public async Task<ActionResult<UserSession>> GetSession(int id)
    {
        var session = await _sessionService.GetSessionByIdAsync(id);
        if (session == null)
            return NotFound();

        return Ok(session);
    }

    /// <summary>
    /// Terminates a session. Requires Global Admin.
    /// </summary>
    [HttpDelete("{sessionKey}")]
    [Authorize(Policy = "RequireGlobalAdmin")]
    public async Task<IActionResult> TerminateSession(string sessionKey)
    {
        var adminName = User.Identity?.Name ?? "Unknown Admin";
        var result = await _sessionService.TerminateSessionAsync(sessionKey, terminatedBy: adminName, isAdminTermination: true);
        
        if (!result)
        {
            return NotFound("Session not found or already terminated");
        }

        return Ok(new { message = "Session terminated successfully" });
    }

    /// <summary>
    /// Updates the heartbeat for the current user session
    /// </summary>
    [HttpPost("heartbeat")]
    public async Task<IActionResult> Heartbeat()
    {
        // This endpoint will trigger the SessionTrackingMiddleware
        // which calls UpdateSessionActivityAsync.
        // But we also need to ensure the session exists if it's the first call using OIDC.
        
        var username = User.Identity?.Name;
        if (string.IsNullOrEmpty(username)) return Unauthorized();

        // Ensure session exists
        // Note: In OIDC, we may not have a traditional HttpContext.Session ID that persists across requests reliably
        // depending on cookie config. 
        // For Client Apps (DV_Web), we might want to pass a client-generated ID or rely on the principal.
        
        // This relies on the middleware to handle the actual update logic
        // But creating the session if missing needs to be explicit.
        
        // Try to get UserId
        var user = await _userService.GetUserByUsernameAsync(username);
        if (user != null)
        {
             await _sessionService.InitializeSessionAsync(username, user.UserId, null);
        }
        
        return Ok();
    }
}

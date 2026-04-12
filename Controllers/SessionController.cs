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
    /// Updates the heartbeat for the current user session.
    /// The middleware handles session initialization, so this just confirms validity.
    /// </summary>
    [HttpPost("heartbeat")]
    public async Task<IActionResult> Heartbeat()
    {
        var username = User.Identity?.Name;
        if (string.IsNullOrEmpty(username)) return Unauthorized();

        // Session is already initialized/refreshed by SessionTrackingMiddleware.
        // Just confirm the session is still valid.
        var sessionKey = HttpContext.Session?.Id;
        var isValid = await _sessionService.IsSessionValidAsync(sessionKey);
        
        return isValid ? Ok() : Unauthorized();
    }
}

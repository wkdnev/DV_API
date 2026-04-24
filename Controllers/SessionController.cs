using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using DV.API.Services;
using DV.Shared.Constants;
using DV.Shared.DTOs;
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

    // ========================================================================
    // Delegated session endpoints — called by UI apps (DV_Web, DV_Admin_UI)
    // ========================================================================

    /// <summary>Initialize or update a session using a key provided by the UI app.</summary>
    [HttpPost("initialize")]
    public async Task<ActionResult<UserSession>> InitializeSession([FromBody] InitializeSessionRequestDto request)
    {
        if (string.IsNullOrWhiteSpace(request.SessionKey) || string.IsNullOrWhiteSpace(request.Username))
            return BadRequest("SessionKey and Username are required");

        var session = await _sessionService.InitializeSessionWithKeyAsync(
            request.SessionKey, request.Username, request.UserId,
            request.IpAddress, request.UserAgent, request.CurrentRole);
        return Ok(session);
    }

    /// <summary>Update session activity from a UI app.</summary>
    [HttpPost("activity")]
    public async Task<IActionResult> UpdateActivity([FromBody] SessionActivityRequestDto request)
    {
        if (string.IsNullOrWhiteSpace(request.SessionKey))
            return BadRequest("SessionKey is required");

        await _sessionService.UpdateSessionActivityByKeyAsync(
            request.SessionKey, request.ActivityType, request.Action, request.Resource);
        return Ok();
    }

    /// <summary>Update session role by session key.</summary>
    [HttpPut("role")]
    public async Task<IActionResult> UpdateRole([FromBody] UpdateSessionRoleRequestDto request)
    {
        if (string.IsNullOrWhiteSpace(request.SessionKey))
            return BadRequest("SessionKey is required");

        await _sessionService.UpdateSessionRoleByKeyAsync(request.SessionKey, request.NewRole);
        return Ok();
    }

    /// <summary>Update session role by username.</summary>
    [HttpPut("role/byusername")]
    public async Task<IActionResult> UpdateRoleByUsername([FromBody] UpdateSessionRoleByUsernameRequestDto request)
    {
        if (string.IsNullOrWhiteSpace(request.Username))
            return BadRequest("Username is required");

        await _sessionService.UpdateSessionRoleByUsernameAsync(request.Username, request.NewRole);
        return Ok();
    }

    /// <summary>Returns 200 if the session is valid, 404 if not found or expired.</summary>
    [HttpGet("validate/{sessionKey}")]
    public async Task<IActionResult> ValidateSession(string sessionKey)
    {
        var isValid = await _sessionService.IsSessionValidAsync(sessionKey);
        return isValid ? Ok() : NotFound();
    }

    /// <summary>Get session statistics. Requires Global Admin.</summary>
    [HttpGet("statistics")]
    [Authorize(Policy = "RequireGlobalAdmin")]
    public async Task<ActionResult<SessionStatistics>> GetStatistics()
    {
        var stats = await _sessionService.GetSessionStatisticsAsync();
        return Ok(stats);
    }

    /// <summary>Get all sessions for a specific user. Requires Global Admin.</summary>
    [HttpGet("user/{userId:int}")]
    [Authorize(Policy = "RequireGlobalAdmin")]
    public async Task<ActionResult<List<UserSession>>> GetUserSessions(int userId, [FromQuery] bool activeOnly = true)
    {
        var sessions = await _sessionService.GetUserSessionsAsync(userId, activeOnly);
        return Ok(sessions);
    }

    /// <summary>Get all sessions for a user by username. Requires Global Admin.</summary>
    [HttpGet("user/byusername/{username}")]
    [Authorize(Policy = "RequireGlobalAdmin")]
    public async Task<ActionResult<List<UserSession>>> GetUserSessionsByUsername(string username, [FromQuery] bool activeOnly = true)
    {
        var sessions = await _sessionService.GetUserSessionsByUsernameAsync(username, activeOnly);
        return Ok(sessions);
    }

    /// <summary>Terminate all sessions for a user by username. Requires Global Admin.</summary>
    [HttpDelete("user/{username}")]
    [Authorize(Policy = "RequireGlobalAdmin")]
    public async Task<IActionResult> TerminateUserSessions(string username)
    {
        var adminName = User.Identity?.Name ?? "Unknown Admin";
        await _sessionService.TerminateAllUserSessionsAsync(username, terminatedBy: adminName);
        return Ok();
    }

    /// <summary>Trigger expired session cleanup. Requires Global Admin.</summary>
    [HttpPost("cleanup")]
    [Authorize(Policy = "RequireGlobalAdmin")]
    public async Task<ActionResult<int>> Cleanup()
    {
        var count = await _sessionService.CleanupExpiredSessionsAsync();
        return Ok(count);
    }
}

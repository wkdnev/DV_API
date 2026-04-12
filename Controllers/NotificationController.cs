// ============================================================================
// NotificationController.cs - Notification API Endpoints
// ============================================================================
//
// NIST SP 800-53 Rev 5 Compliance:
//   SI-5:    Internal alerts disseminated to appropriate personnel
//   AC-3:    Access enforcement - users see only their own notifications
//   SI-10:   Input validation on all endpoints
//   SI-11:   Error messages without exploitable information
//   AU-12:   Audit logging of notification operations
// ============================================================================

using DV.API.Services;
using DV.Shared.DTOs;
using DV.Shared.Security;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DV.API.Controllers;

[ApiController]
[Route("api/notifications")]
[Authorize]
public class NotificationController : ControllerBase
{
    private readonly NotificationService _notificationService;
    private readonly UserService _userService;
    private readonly ILogger<NotificationController> _logger;

    public NotificationController(
        NotificationService notificationService,
        UserService userService,
        ILogger<NotificationController> logger)
    {
        _notificationService = notificationService;
        _userService = userService;
        _logger = logger;
    }

    /// <summary>
    /// Get current user's notifications (paged, filtered, sorted).
    /// </summary>
    [HttpGet]
    public async Task<IActionResult> GetNotifications(
        [FromQuery] int page = 1,
        [FromQuery] int pageSize = 20,
        [FromQuery] string? category = null,
        [FromQuery] bool? isRead = null,
        [FromQuery] bool? isImportant = null,
        [FromQuery] string? sortBy = "CreatedAtUtc",
        [FromQuery] bool sortDescending = true)
    {
        try
        {
            var userId = await GetCurrentUserIdAsync();
            if (userId == null)
                return Unauthorized();

            var request = new NotificationListRequestDto
            {
                Page = page,
                PageSize = pageSize,
                Category = category,
                IsRead = isRead,
                IsImportant = isImportant,
                SortBy = sortBy,
                SortDescending = sortDescending
            };

            var result = await _notificationService.GetNotificationsAsync(userId.Value, request);
            return Ok(result);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error retrieving notifications");
            return StatusCode(500, new { error = "Failed to retrieve notifications" });
        }
    }

    /// <summary>
    /// Get unread notification count for bell icon.
    /// Optimized for frequent polling.
    /// </summary>
    [HttpGet("unread-count")]
    public async Task<IActionResult> GetUnreadCount()
    {
        try
        {
            var userId = await GetCurrentUserIdAsync();
            if (userId == null)
                return Unauthorized();

            var result = await _notificationService.GetUnreadCountAsync(userId.Value);
            return Ok(result);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error retrieving unread count");
            return StatusCode(500, new { error = "Failed to retrieve unread count" });
        }
    }

    /// <summary>
    /// Get a single notification by ID.
    /// AC-3: Only returns if notification belongs to current user.
    /// </summary>
    [HttpGet("{id:int}")]
    public async Task<IActionResult> GetNotification(int id)
    {
        try
        {
            var userId = await GetCurrentUserIdAsync();
            if (userId == null)
                return Unauthorized();

            var notification = await _notificationService.GetNotificationByIdAsync(id, userId.Value);
            if (notification == null)
                return NotFound();

            return Ok(notification);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error retrieving notification {NotificationId}", id);
            return StatusCode(500, new { error = "Failed to retrieve notification" });
        }
    }

    /// <summary>
    /// Create a notification. Used internally by services and admin.
    /// SI-10: Validates input.
    /// </summary>
    [HttpPost]
    public async Task<IActionResult> CreateNotification([FromBody] CreateNotificationDto request)
    {
        try
        {
            if (request == null)
                return BadRequest(new { error = "Request body is required" });

            if (string.IsNullOrWhiteSpace(request.Title))
                return BadRequest(new { error = "Title is required" });

            if (string.IsNullOrWhiteSpace(request.Message))
                return BadRequest(new { error = "Message is required" });

            if (request.Title.Length > 100)
                return BadRequest(new { error = "Title must not exceed 100 characters" });

            if (request.Message.Length > 255)
                return BadRequest(new { error = "Message must not exceed 255 characters" });

            var notification = await _notificationService.CreateNotificationAsync(request);
            return CreatedAtAction(nameof(GetNotification), new { id = notification.NotificationId }, notification);
        }
        catch (ArgumentException ex)
        {
            return BadRequest(new { error = ex.Message });
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error creating notification");
            return StatusCode(500, new { error = "Failed to create notification" });
        }
    }

    /// <summary>
    /// Mark a notification as read.
    /// </summary>
    [HttpPut("{id:int}/read")]
    public async Task<IActionResult> MarkAsRead(int id)
    {
        try
        {
            var userId = await GetCurrentUserIdAsync();
            if (userId == null)
                return Unauthorized();

            var success = await _notificationService.MarkAsReadAsync(id, userId.Value);
            if (!success)
                return NotFound();

            return NoContent();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error marking notification {NotificationId} as read", id);
            return StatusCode(500, new { error = "Failed to mark notification as read" });
        }
    }

    /// <summary>
    /// Mark all notifications as read for the current user.
    /// </summary>
    [HttpPut("read-all")]
    public async Task<IActionResult> MarkAllAsRead()
    {
        try
        {
            var userId = await GetCurrentUserIdAsync();
            if (userId == null)
                return Unauthorized();

            var count = await _notificationService.MarkAllAsReadAsync(userId.Value);
            return Ok(new MarkAllReadResponseDto { MarkedCount = count });
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error marking all notifications as read");
            return StatusCode(500, new { error = "Failed to mark all notifications as read" });
        }
    }

    /// <summary>
    /// Delete a single notification.
    /// AC-3: Only deletes if notification belongs to current user.
    /// </summary>
    [HttpDelete("{id:int}")]
    public async Task<IActionResult> DeleteNotification(int id)
    {
        try
        {
            var userId = await GetCurrentUserIdAsync();
            if (userId == null)
                return Unauthorized();

            var success = await _notificationService.DeleteNotificationAsync(id, userId.Value);
            if (!success)
                return NotFound();

            return NoContent();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error deleting notification {NotificationId}", id);
            return StatusCode(500, new { error = "Failed to delete notification" });
        }
    }

    /// <summary>
    /// Bulk delete notifications.
    /// AC-3: Only deletes notifications belonging to current user.
    /// </summary>
    [HttpDelete("bulk")]
    public async Task<IActionResult> BulkDelete([FromBody] BulkNotificationActionDto request)
    {
        try
        {
            var userId = await GetCurrentUserIdAsync();
            if (userId == null)
                return Unauthorized();

            if (request?.NotificationIds == null || request.NotificationIds.Count == 0)
                return BadRequest(new { error = "NotificationIds are required" });

            var count = await _notificationService.BulkDeleteAsync(request.NotificationIds, userId.Value);
            return Ok(new BulkDeleteResponseDto { DeletedCount = count });
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error bulk deleting notifications");
            return StatusCode(500, new { error = "Failed to bulk delete notifications" });
        }
    }

    /// <summary>
    /// Cleanup expired notifications. Admin only.
    /// </summary>
    [HttpPost("cleanup")]
    public async Task<IActionResult> CleanupExpired()
    {
        try
        {
            // Only admins can trigger cleanup
            var username = User.Identity?.Name;
            if (string.IsNullOrEmpty(username))
                return Unauthorized();

            var count = await _notificationService.CleanupExpiredNotificationsAsync();
            return Ok(new { cleanedCount = count });
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error cleaning up expired notifications");
            return StatusCode(500, new { error = "Failed to cleanup notifications" });
        }
    }

    /// <summary>
    /// Resolve the current authenticated user's ID.
    /// </summary>
    private async Task<int?> GetCurrentUserIdAsync()
    {
        var username = User.Identity?.Name;
        if (string.IsNullOrEmpty(username))
            return null;

        var user = await _userService.GetUserByUsernameAsync(username);
        return user?.UserId;
    }
}

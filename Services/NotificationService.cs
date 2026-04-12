// ============================================================================
// NotificationService.cs - In-App Notification Service
// ============================================================================
//
// NIST SP 800-53 Rev 5 Compliance:
//   SI-5:     Generate and disseminate internal security alerts
//   SI-5(1):  Automated alerts broadcast mechanism
//   AU-12:    Audit record generation for notification events
//   AU-3:     Content: what, when, where, who, outcome
//   AC-3:     Access enforcement - user-scoped data access
//   SI-10:    Input validation on notification content
//   SI-11:    Error handling without exploitable information
//   AU-8:     UTC timestamps throughout
// ============================================================================

using DV.API.Data;
using DV.Shared.DTOs;
using DV.Shared.Interfaces;
using DV.Shared.Security;
using Microsoft.EntityFrameworkCore;

namespace DV.API.Services;

public class NotificationService : INotificationService
{
    private readonly SecurityDbContext _context;
    private readonly ILogger<NotificationService> _logger;

    public NotificationService(
        SecurityDbContext context,
        ILogger<NotificationService> logger)
    {
        _context = context;
        _logger = logger;
    }

    /// <summary>
    /// Ensure the Notification table exists in the database.
    /// Uses IF NOT EXISTS to safely run at every startup.
    /// </summary>
    public async Task EnsureTableExistsAsync()
    {
        try
        {
            var createTableSql = @"
                CREATE TABLE IF NOT EXISTS ""dbo"".""Notification"" (
                    ""NotificationId"" SERIAL NOT NULL,
                    ""UserId"" integer NOT NULL,
                    ""Title"" varchar(100) NOT NULL,
                    ""Message"" varchar(255) NOT NULL,
                    ""Category"" varchar(50) NOT NULL DEFAULT 'General',
                    ""IsRead"" boolean NOT NULL DEFAULT false,
                    ""IsImportant"" boolean NOT NULL DEFAULT false,
                    ""CreatedAtUtc"" timestamp NOT NULL DEFAULT (NOW() AT TIME ZONE 'UTC'),
                    ""ReadAtUtc"" timestamp NULL,
                    ""SourceSystem"" varchar(50) NULL,
                    ""CorrelationId"" varchar(100) NULL,
                    ""ExpiresAtUtc"" timestamp NULL,
                    CONSTRAINT ""PK_Notification"" PRIMARY KEY (""NotificationId""),
                    CONSTRAINT ""FK_Notification_ApplicationUser"" FOREIGN KEY (""UserId"")
                        REFERENCES ""dbo"".""ApplicationUser"" (""UserId"") ON DELETE CASCADE
                );

                CREATE INDEX IF NOT EXISTS ""IX_Notification_User_Read"" ON ""dbo"".""Notification"" (""UserId"", ""IsRead"");
                CREATE INDEX IF NOT EXISTS ""IX_Notification_User_Created"" ON ""dbo"".""Notification"" (""UserId"", ""CreatedAtUtc"" DESC);
                CREATE INDEX IF NOT EXISTS ""IX_Notification_Expires"" ON ""dbo"".""Notification"" (""ExpiresAtUtc"");
                CREATE INDEX IF NOT EXISTS ""IX_Notification_User_Important_Read"" ON ""dbo"".""Notification"" (""UserId"", ""IsImportant"", ""IsRead"");";

            await _context.Database.ExecuteSqlRawAsync(createTableSql);
            _logger.LogInformation("Notification table verified/created successfully");
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Failed to ensure Notification table exists");
            throw;
        }
    }

    /// <summary>
    /// Get paginated, filtered, sorted notifications for a user.
    /// AC-3: Only returns notifications belonging to the specified user.
    /// </summary>
    public async Task<NotificationListResponseDto> GetNotificationsAsync(int userId, NotificationListRequestDto request)
    {
        var query = _context.Notifications
            .Where(n => n.UserId == userId)
            .AsQueryable();

        // Apply filters
        if (!string.IsNullOrEmpty(request.Category))
            query = query.Where(n => n.Category == request.Category);

        if (request.IsRead.HasValue)
            query = query.Where(n => n.IsRead == request.IsRead.Value);

        if (request.IsImportant.HasValue)
            query = query.Where(n => n.IsImportant == request.IsImportant.Value);

        // Get total count and unread count
        var totalCount = await query.CountAsync();
        var unreadCount = await _context.Notifications
            .Where(n => n.UserId == userId && !n.IsRead)
            .CountAsync();

        // Apply sorting
        query = request.SortBy?.ToLowerInvariant() switch
        {
            "title" => request.SortDescending ? query.OrderByDescending(n => n.Title) : query.OrderBy(n => n.Title),
            "category" => request.SortDescending ? query.OrderByDescending(n => n.Category) : query.OrderBy(n => n.Category),
            "isread" => request.SortDescending ? query.OrderByDescending(n => n.IsRead) : query.OrderBy(n => n.IsRead),
            "isimportant" => request.SortDescending ? query.OrderByDescending(n => n.IsImportant) : query.OrderBy(n => n.IsImportant),
            _ => request.SortDescending ? query.OrderByDescending(n => n.CreatedAtUtc) : query.OrderBy(n => n.CreatedAtUtc)
        };

        // Apply pagination
        var pageSize = Math.Clamp(request.PageSize, 1, 100);
        var page = Math.Max(request.Page, 1);
        var skip = (page - 1) * pageSize;

        var notifications = await query
            .Skip(skip)
            .Take(pageSize)
            .Select(n => MapToDto(n))
            .ToListAsync();

        return new NotificationListResponseDto
        {
            Notifications = notifications,
            TotalCount = totalCount,
            UnreadCount = unreadCount,
            Page = page,
            PageSize = pageSize,
            TotalPages = (int)Math.Ceiling((double)totalCount / pageSize)
        };
    }

    /// <summary>
    /// Get unread notification count for bell icon display.
    /// Optimized query for frequent polling.
    /// </summary>
    public async Task<UnreadCountDto> GetUnreadCountAsync(int userId)
    {
        var unreadCount = await _context.Notifications
            .Where(n => n.UserId == userId && !n.IsRead)
            .CountAsync();

        var importantUnreadCount = await _context.Notifications
            .Where(n => n.UserId == userId && !n.IsRead && n.IsImportant)
            .CountAsync();

        return new UnreadCountDto
        {
            UnreadCount = unreadCount,
            ImportantUnreadCount = importantUnreadCount
        };
    }

    /// <summary>
    /// Get a single notification by ID.
    /// AC-3: Enforces user ownership.
    /// </summary>
    public async Task<NotificationDto?> GetNotificationByIdAsync(int notificationId, int userId)
    {
        var notification = await _context.Notifications
            .FirstOrDefaultAsync(n => n.NotificationId == notificationId && n.UserId == userId);

        return notification != null ? MapToDto(notification) : null;
    }

    /// <summary>
    /// Create a new notification for a user.
    /// SI-5: Internal alert generation.
    /// SI-10: Validates input before persisting.
    /// AU-8: Timestamps in UTC.
    /// </summary>
    public async Task<NotificationDto> CreateNotificationAsync(CreateNotificationDto request)
    {
        // SI-10: Input validation
        if (request.UserId <= 0)
            throw new ArgumentException("Valid UserId is required");

        if (string.IsNullOrWhiteSpace(request.Title) || request.Title.Length > 100)
            throw new ArgumentException("Title is required and must not exceed 100 characters");

        if (string.IsNullOrWhiteSpace(request.Message) || request.Message.Length > 255)
            throw new ArgumentException("Message is required and must not exceed 255 characters");

        var notification = new Notification
        {
            UserId = request.UserId,
            Title = request.Title.Trim(),
            Message = request.Message.Trim(),
            Category = string.IsNullOrWhiteSpace(request.Category) ? NotificationCategories.General : request.Category.Trim(),
            IsImportant = request.IsImportant,
            SourceSystem = request.SourceSystem,
            CorrelationId = request.CorrelationId,
            CreatedAtUtc = DateTime.UtcNow,
            ExpiresAtUtc = request.ExpiresInDays.HasValue
                ? DateTime.UtcNow.AddDays(request.ExpiresInDays.Value)
                : DateTime.UtcNow.AddDays(90) // Default 90-day retention
        };

        _context.Notifications.Add(notification);
        await _context.SaveChangesAsync();

        _logger.LogInformation(
            "Notification created: Id={NotificationId}, User={UserId}, Category={Category}, Title={Title}",
            notification.NotificationId, notification.UserId, notification.Category, notification.Title);

        return MapToDto(notification);
    }

    /// <summary>
    /// Mark a notification as read.
    /// AC-3: Enforces user ownership.
    /// </summary>
    public async Task<bool> MarkAsReadAsync(int notificationId, int userId)
    {
        var notification = await _context.Notifications
            .FirstOrDefaultAsync(n => n.NotificationId == notificationId && n.UserId == userId);

        if (notification == null)
            return false;

        if (!notification.IsRead)
        {
            notification.IsRead = true;
            notification.ReadAtUtc = DateTime.UtcNow;
            await _context.SaveChangesAsync();
        }

        return true;
    }

    /// <summary>
    /// Mark all notifications as read for a user.
    /// </summary>
    public async Task<int> MarkAllAsReadAsync(int userId)
    {
        var now = DateTime.UtcNow;
        var unreadNotifications = await _context.Notifications
            .Where(n => n.UserId == userId && !n.IsRead)
            .ToListAsync();

        foreach (var notification in unreadNotifications)
        {
            notification.IsRead = true;
            notification.ReadAtUtc = now;
        }

        await _context.SaveChangesAsync();

        _logger.LogInformation("Marked {Count} notifications as read for User={UserId}",
            unreadNotifications.Count, userId);

        return unreadNotifications.Count;
    }

    /// <summary>
    /// Delete a single notification.
    /// AC-3: Enforces user ownership.
    /// </summary>
    public async Task<bool> DeleteNotificationAsync(int notificationId, int userId)
    {
        var notification = await _context.Notifications
            .FirstOrDefaultAsync(n => n.NotificationId == notificationId && n.UserId == userId);

        if (notification == null)
            return false;

        _context.Notifications.Remove(notification);
        await _context.SaveChangesAsync();

        return true;
    }

    /// <summary>
    /// Bulk delete notifications.
    /// AC-3: Only deletes notifications belonging to the specified user.
    /// </summary>
    public async Task<int> BulkDeleteAsync(List<int> notificationIds, int userId)
    {
        if (notificationIds == null || notificationIds.Count == 0)
            return 0;

        var notifications = await _context.Notifications
            .Where(n => notificationIds.Contains(n.NotificationId) && n.UserId == userId)
            .ToListAsync();

        _context.Notifications.RemoveRange(notifications);
        await _context.SaveChangesAsync();

        _logger.LogInformation("Bulk deleted {Count} notifications for User={UserId}",
            notifications.Count, userId);

        return notifications.Count;
    }

    /// <summary>
    /// Cleanup expired notifications. Called by background service.
    /// </summary>
    public async Task<int> CleanupExpiredNotificationsAsync()
    {
        var now = DateTime.UtcNow;
        var expired = await _context.Notifications
            .Where(n => n.ExpiresAtUtc != null && n.ExpiresAtUtc <= now)
            .ToListAsync();

        if (expired.Count > 0)
        {
            _context.Notifications.RemoveRange(expired);
            await _context.SaveChangesAsync();

            _logger.LogInformation("Cleaned up {Count} expired notifications", expired.Count);
        }

        return expired.Count;
    }

    /// <summary>
    /// SI-5(1): Create notifications for multiple users at once (broadcast).
    /// Used for system-wide alerts.
    /// </summary>
    public async Task<int> CreateBulkNotificationsAsync(
        List<int> userIds,
        string title,
        string message,
        string category,
        bool isImportant = false,
        string? sourceSystem = null,
        string? correlationId = null,
        int? expiresInDays = null)
    {
        if (userIds == null || userIds.Count == 0)
            return 0;

        var now = DateTime.UtcNow;
        var expiresAt = expiresInDays.HasValue
            ? now.AddDays(expiresInDays.Value)
            : now.AddDays(90);

        var notifications = userIds.Select(userId => new Notification
        {
            UserId = userId,
            Title = title.Trim(),
            Message = message.Trim(),
            Category = category,
            IsImportant = isImportant,
            SourceSystem = sourceSystem,
            CorrelationId = correlationId,
            CreatedAtUtc = now,
            ExpiresAtUtc = expiresAt
        }).ToList();

        _context.Notifications.AddRange(notifications);
        await _context.SaveChangesAsync();

        _logger.LogInformation(
            "Broadcast notification to {UserCount} users: Category={Category}, Title={Title}",
            userIds.Count, category, title);

        return notifications.Count;
    }

    private static NotificationDto MapToDto(Notification n) => new()
    {
        NotificationId = n.NotificationId,
        UserId = n.UserId,
        Title = n.Title,
        Message = n.Message,
        Category = n.Category,
        IsRead = n.IsRead,
        IsImportant = n.IsImportant,
        CreatedAtUtc = n.CreatedAtUtc,
        ReadAtUtc = n.ReadAtUtc,
        SourceSystem = n.SourceSystem,
        CorrelationId = n.CorrelationId,
        RelativeTime = GetRelativeTime(n.CreatedAtUtc)
    };

    private static string GetRelativeTime(DateTime utcTime)
    {
        var span = DateTime.UtcNow - utcTime;

        if (span.TotalMinutes < 1) return "Just now";
        if (span.TotalMinutes < 60) return $"{(int)span.TotalMinutes}m ago";
        if (span.TotalHours < 24) return $"{(int)span.TotalHours}h ago";
        if (span.TotalDays < 7) return $"{(int)span.TotalDays}d ago";
        if (span.TotalDays < 30) return $"{(int)(span.TotalDays / 7)}w ago";

        return utcTime.ToString("MMM dd, yyyy");
    }
}

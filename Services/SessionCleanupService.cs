using DV.API.Services;
using DV.Shared.Constants;

namespace DV.API.Services;

/// <summary>
/// Background service to periodically clean up expired sessions and notifications.
/// Only the API should run this to avoid multiple services competing on the same DB table.
/// </summary>
public class SessionCleanupService : BackgroundService
{
    private readonly IServiceProvider _serviceProvider;
    private readonly ILogger<SessionCleanupService> _logger;
    private readonly TimeSpan _cleanupInterval = TimeSpan.FromMinutes(SessionConfig.CleanupIntervalMinutes);

    public SessionCleanupService(IServiceProvider serviceProvider, ILogger<SessionCleanupService> logger)
    {
        _serviceProvider = serviceProvider;
        _logger = logger;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        _logger.LogInformation("Session cleanup service started (interval: {Interval}min)", SessionConfig.CleanupIntervalMinutes);

        // Ensure Notification table exists on startup
        try
        {
            using var initScope = _serviceProvider.CreateScope();
            var notificationService = initScope.ServiceProvider.GetRequiredService<NotificationService>();
            await notificationService.EnsureTableExistsAsync();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Failed to initialize Notification table");
        }

        while (!stoppingToken.IsCancellationRequested)
        {
            try
            {
                using var scope = _serviceProvider.CreateScope();
                var sessionService = scope.ServiceProvider.GetRequiredService<SessionManagementService>();
                var notificationService = scope.ServiceProvider.GetRequiredService<NotificationService>();
                
                var sessionCleanupCount = await sessionService.CleanupExpiredSessionsAsync();
                if (sessionCleanupCount > 0)
                {
                    _logger.LogInformation("Cleaned up {CleanupCount} expired sessions", sessionCleanupCount);
                }

                var notificationCleanupCount = await notificationService.CleanupExpiredNotificationsAsync();
                if (notificationCleanupCount > 0)
                {
                    _logger.LogInformation("Cleaned up {CleanupCount} expired notifications", notificationCleanupCount);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error during cleanup cycle");
            }

            try
            {
                await Task.Delay(_cleanupInterval, stoppingToken);
            }
            catch (TaskCanceledException)
            {
                break;
            }
        }

        _logger.LogInformation("Session cleanup service stopped");
    }
}




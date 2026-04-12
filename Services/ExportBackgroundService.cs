namespace DV.API.Services;

/// <summary>
/// Background service that processes queued bulk export jobs.
/// </summary>
public class ExportBackgroundService : BackgroundService
{
    private readonly IExportTaskQueue _taskQueue;
    private readonly BulkExportService _exportService;
    private readonly ILogger<ExportBackgroundService> _logger;

    public ExportBackgroundService(
        IExportTaskQueue taskQueue,
        BulkExportService exportService,
        ILogger<ExportBackgroundService> logger)
    {
        _taskQueue = taskQueue;
        _exportService = exportService;
        _logger = logger;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        _logger.LogInformation("Export Background Service is running.");

        while (!stoppingToken.IsCancellationRequested)
        {
            var workItem = await _taskQueue.DequeueAsync(stoppingToken);

            _logger.LogInformation("Processing export job {JobId}", workItem.JobId);

            try
            {
                await _exportService.ExecuteExportAsync(workItem, stoppingToken);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error processing export job {JobId}", workItem.JobId);
            }
        }
    }
}

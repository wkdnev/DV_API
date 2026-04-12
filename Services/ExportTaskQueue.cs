using System.Threading.Channels;
using DV.Shared.Models;

namespace DV.API.Services;

/// <summary>
/// Queued work item for a bulk export operation.
/// </summary>
public class ExportWorkItem
{
    public Guid JobId { get; set; }
    public BulkExportRequest Request { get; set; } = null!;
    public int UserId { get; set; }
    public string Username { get; set; } = string.Empty;
    public CancellationTokenSource CancellationSource { get; set; } = new();
}

/// <summary>
/// Channel-based queue for bulk export jobs.
/// </summary>
public interface IExportTaskQueue
{
    ValueTask QueueAsync(ExportWorkItem item);
    ValueTask<ExportWorkItem> DequeueAsync(CancellationToken cancellationToken);
}

public class ExportTaskQueue : IExportTaskQueue
{
    private readonly Channel<ExportWorkItem> _queue;

    public ExportTaskQueue()
    {
        var options = new BoundedChannelOptions(10)
        {
            FullMode = BoundedChannelFullMode.Wait
        };
        _queue = Channel.CreateBounded<ExportWorkItem>(options);
    }

    public async ValueTask QueueAsync(ExportWorkItem item)
    {
        await _queue.Writer.WriteAsync(item);
    }

    public async ValueTask<ExportWorkItem> DequeueAsync(CancellationToken cancellationToken)
    {
        return await _queue.Reader.ReadAsync(cancellationToken);
    }
}

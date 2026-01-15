using Microsoft.AspNetCore.Mvc;
using DV.API.Infrastructure.Caching;

namespace DV.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CacheController : ControllerBase
{
    private readonly ICacheService _cache;
    private readonly ILogger<CacheController> _logger;

    public CacheController(ICacheService cache, ILogger<CacheController> logger)
    {
        _cache = cache;
        _logger = logger;
    }

    [HttpPost("clear-permissions")]
    public async Task<IActionResult> ClearPermissionCache()
    {
        try
        {
            await _cache.RemoveByPatternAsync("user:permission:");
            _logger.LogInformation("Permission cache cleared via API");
            return Ok(new { message = "Permission cache cleared successfully" });
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error clearing permission cache");
            return StatusCode(500, new { error = ex.Message });
        }
    }

    [HttpPost("clear-all")]
    public async Task<IActionResult> ClearAllCache()
    {
        try
        {
            await _cache.RemoveByPatternAsync("");
            _logger.LogInformation("All cache cleared via API");
            return Ok(new { message = "All cache cleared successfully" });
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error clearing all cache");
            return StatusCode(500, new { error = ex.Message });
        }
    }

    [HttpGet("stats")]
    public async Task<IActionResult> GetCacheStats()
    {
        try
        {
            var stats = await _cache.GetStatisticsAsync();
            return Ok(stats);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error getting cache statistics");
            return StatusCode(500, new { error = ex.Message });
        }
    }
}


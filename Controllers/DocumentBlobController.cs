using DV.API.Data;
using DV.API.Services;
using DV.Shared.DTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Formats.Jpeg;
using SixLabors.ImageSharp.Processing;
using Microsoft.AspNetCore.Components.Authorization;
using DV.Shared.Security;

namespace DV.API.Controllers;

/// <summary>
/// API Controller for serving documents from BLOB storage
/// </summary>
[ApiController]
[Route("api/[controller]")]
[Authorize]
public class DocumentBlobController : ControllerBase
{
    private readonly DocumentUploadService _documentUploadService;
    private readonly DocumentRepository _repo;
    private readonly NotificationService _notificationService;
    private readonly ILogger<DocumentBlobController> _logger;
    private readonly IDbContextFactory<SecurityDbContext> _securityDbContextFactory;
    private readonly AuthenticationStateProvider _authenticationStateProvider;
    private readonly IMemoryCache _cache;

    public DocumentBlobController(DocumentUploadService documentUploadService, DocumentRepository repo, NotificationService notificationService,
        ILogger<DocumentBlobController> logger,
        IDbContextFactory<SecurityDbContext> securityDbContextFactory, AuthenticationStateProvider authenticationStateProvider,
        IMemoryCache cache)
    {
        _documentUploadService = documentUploadService;
        _repo = repo;
        _notificationService = notificationService;
        _logger = logger;
        _securityDbContextFactory = securityDbContextFactory;
        _authenticationStateProvider = authenticationStateProvider;
        _cache = cache;
    }

    /// <summary>
    /// Serves document page content from BLOB storage
    /// </summary>
    /// <param name="pageId">Document page ID</param>
    /// <param name="inline">Whether to display inline or as attachment</param>
    /// <returns>Document content as file result</returns>
    [HttpGet("page/{pageId:int}")]
    public async Task<IActionResult> GetDocumentPage(int pageId, bool inline = true)
    {
        try
        {
            var content = await _documentUploadService.GetDocumentPageContentAsync(pageId);
            
            if (content == null)
            {
                _logger.LogWarning("Document page {PageId} not found", pageId);
                return NotFound("Document page not found");
            }

            var (fileContent, contentType, fileName) = content.Value;

            // Set content disposition
            var contentDisposition = inline ? "inline" : "attachment";
            Response.Headers["Content-Disposition"] = $"{contentDisposition}; filename=\"{fileName}\"";
            
            // Add cache headers for better performance
            Response.Headers["Cache-Control"] = "public, max-age=3600"; // 1 hour cache
            Response.Headers["ETag"] = $"\"{pageId}\"";

            return File(fileContent, contentType);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error serving document page {PageId}", pageId);
            return StatusCode(500, "Error retrieving document");
        }
    }

    /// <summary>
    /// Serves document page as thumbnail (smaller version for previews)
    /// </summary>
    /// <param name="pageId">Document page ID</param>
    /// <param name="width">Thumbnail width (optional)</param>
    /// <param name="height">Thumbnail height (optional)</param>
    /// <returns>Thumbnail image</returns>
    [HttpGet("page/{pageId:int}/thumbnail")]
    public async Task<IActionResult> GetDocumentThumbnail(int pageId, int? width = null, int? height = null)
    {
        try
        {
            var content = await _documentUploadService.GetDocumentPageContentAsync(pageId);
            
            if (content == null)
            {
                _logger.LogWarning("Document page {PageId} not found for thumbnail", pageId);
                return NotFound("Document page not found");
            }

            var (fileContent, contentType, fileName) = content.Value;

            // For now, return the original content
            // TODO: Implement image resizing for actual thumbnails
            Response.Headers["Cache-Control"] = "public, max-age=7200"; // 2 hour cache for thumbnails
            Response.Headers["ETag"] = $"\"thumb-{pageId}\"";

            return File(fileContent, contentType);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error serving thumbnail for document page {PageId}", pageId);
            return StatusCode(500, "Error retrieving thumbnail");
        }
    }

    /// <summary>
    /// Gets document page as JPEG (converts TIFF if needed)
    /// </summary>
    /// <param name="pageId">Document page ID</param>
    /// <returns>Document content as JPEG</returns>
    [HttpGet("page/{pageId:int}/jpeg")]
    public async Task<IActionResult> GetDocumentPageAsJpeg(int pageId)
    {
        try
        {
            var content = await _documentUploadService.GetDocumentPageContentAsync(pageId);
            
            if (content == null)
            {
                _logger.LogWarning("Document page {PageId} not found for JPEG conversion", pageId);
                return NotFound("Document page not found");
            }

            var (fileContent, contentType, fileName) = content.Value;

            // If it's already a JPEG or PNG, return it as-is
            if (contentType?.ToLower().Contains("jpeg") == true || 
                contentType?.ToLower().Contains("jpg") == true ||
                contentType?.ToLower().Contains("png") == true)
            {
                Response.Headers["Cache-Control"] = "public, max-age=3600";
                Response.Headers["ETag"] = $"\"{pageId}\"";
                return File(fileContent, contentType);
            }

            // Convert TIFF to JPEG using ImageSharp
            try
            {
                using var inputStream = new MemoryStream(fileContent);
                using var image = Image.Load(inputStream);
                
                using var outputStream = new MemoryStream();
                image.SaveAsJpeg(outputStream, new JpegEncoder
                {
                    Quality = 90
                });
                
                var bytes = outputStream.ToArray();
                
                _logger.LogInformation("Successfully converted TIFF to JPEG for page {PageId}, size: {Size} bytes", pageId, bytes.Length);

                Response.Headers["Cache-Control"] = "public, max-age=3600";
                Response.Headers["ETag"] = $"\"{pageId}\"";
                
                return File(bytes, "image/jpeg");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error converting TIFF to JPEG for page {PageId}. ContentType: {ContentType}, FileSize: {FileSize}", 
                    pageId, contentType, fileContent.Length);
                return StatusCode(500, $"Error converting image to JPEG: {ex.Message}");
            }
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error serving JPEG for document page {PageId}", pageId);
            return StatusCode(500, "Error retrieving document");
        }
    }

    /// <summary>
    /// Downloads document page as attachment
    /// </summary>
    /// <param name="pageId">Document page ID</param>
    /// <returns>Document content as download</returns>
    [HttpGet("page/{pageId:int}/download")]
    public async Task<IActionResult> DownloadDocumentPage(int pageId)
    {
        return await GetDocumentPage(pageId, inline: false);
    }

    /// <summary>
    /// Gets document page metadata without content
    /// </summary>
    /// <param name="pageId">Document page ID</param>
    /// <returns>Document page metadata</returns>
    [HttpGet("page/{pageId:int}/info")]
    public async Task<IActionResult> GetDocumentPageInfo(int pageId)
    {
        try
        {
            // This would require a method in DocumentUploadService to get metadata only
            var content = await _documentUploadService.GetDocumentPageContentAsync(pageId);
            
            if (content == null)
            {
                return NotFound("Document page not found");
            }

            var (fileContent, contentType, fileName) = content.Value;

            var info = new
            {
                PageId = pageId,
                FileName = fileName,
                ContentType = contentType,
                FileSize = fileContent.Length,
                DownloadUrl = Url.Action(nameof(DownloadDocumentPage), new { pageId }),
                ViewUrl = Url.Action(nameof(GetDocumentPage), new { pageId }),
                ThumbnailUrl = Url.Action(nameof(GetDocumentThumbnail), new { pageId })
            };

            return Ok(info);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error getting info for document page {PageId}", pageId);
            return StatusCode(500, "Error retrieving document info");
        }
    }

    /// <summary>
    /// Returns image metadata needed for tiled viewing (dimensions, tile size, levels)
    /// </summary>
    [HttpGet("page/{pageId:int}/image-info")]
    public async Task<IActionResult> GetImageInfo(int pageId)
    {
        try
        {
            var cacheKey = $"imginfo_{pageId}";
            if (_cache.TryGetValue(cacheKey, out object? cached))
                return Ok(cached);

            var content = await _documentUploadService.GetDocumentPageContentAsync(pageId);
            if (content == null)
                return NotFound("Document page not found");

            var (fileContent, contentType, fileName) = content.Value;

            // Check if this is an image we can identify
            var isImage = contentType != null && (
                contentType.Contains("image", StringComparison.OrdinalIgnoreCase) ||
                contentType.Contains("tiff", StringComparison.OrdinalIgnoreCase));

            if (!isImage)
                return BadRequest("Not an image file");

            using var stream = new MemoryStream(fileContent);
            var imageInfo = Image.Identify(stream);

            if (imageInfo == null)
                return BadRequest("Could not identify image dimensions");

            int tileSize = 256;
            int maxDim = Math.Max(imageInfo.Width, imageInfo.Height);
            int maxLevel = maxDim > 1 ? (int)Math.Ceiling(Math.Log2(maxDim)) : 0;

            var result = new
            {
                width = imageInfo.Width,
                height = imageInfo.Height,
                tileSize = tileSize,
                maxLevel = maxLevel,
                format = contentType,
                fileSize = fileContent.Length
            };

            _cache.Set(cacheKey, result, TimeSpan.FromHours(4));
            return Ok(result);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error getting image info for page {PageId}", pageId);
            return StatusCode(500, "Error retrieving image info");
        }
    }

    /// <summary>
    /// Serves a single tile from an image for progressive deep-zoom viewing.
    /// Tiles are generated on-demand from the original BLOB and cached in memory.
    /// </summary>
    [HttpGet("page/{pageId:int}/tile/{level:int}/{col:int}/{row:int}")]
    public async Task<IActionResult> GetTile(int pageId, int level, int col, int row)
    {
        try
        {
            int tileSize = 256;
            var tileCacheKey = $"tile_{pageId}_{level}_{col}_{row}";

            // Return cached tile if available
            if (_cache.TryGetValue(tileCacheKey, out byte[]? cachedTile) && cachedTile != null)
            {
                Response.Headers["Cache-Control"] = "public, max-age=86400"; // 24h
                return File(cachedTile, "image/jpeg");
            }

            // Get the original BLOB bytes (cached separately to avoid repeated DB hits)
            var blobCacheKey = $"blob_{pageId}";
            if (!_cache.TryGetValue(blobCacheKey, out (byte[] bytes, string contentType, string fileName) blob))
            {
                var content = await _documentUploadService.GetDocumentPageContentAsync(pageId);
                if (content == null)
                    return NotFound("Document page not found");

                blob = content.Value;
                _cache.Set(blobCacheKey, blob,
                    new MemoryCacheEntryOptions { SlidingExpiration = TimeSpan.FromMinutes(5) });
            }

            // Decode image
            using var inputStream = new MemoryStream(blob.bytes);
            using var image = Image.Load(inputStream);

            int imgWidth = image.Width;
            int imgHeight = image.Height;
            int maxDim = Math.Max(imgWidth, imgHeight);
            int maxLevel = maxDim > 1 ? (int)Math.Ceiling(Math.Log2(maxDim)) : 0;

            if (level > maxLevel || level < 0)
                return NotFound("Invalid level");

            // At this level, the scaled image dimensions
            double scaleFactor = Math.Pow(2, level) / Math.Pow(2, maxLevel);
            int levelWidth = Math.Max(1, (int)Math.Ceiling(imgWidth * scaleFactor));
            int levelHeight = Math.Max(1, (int)Math.Ceiling(imgHeight * scaleFactor));

            // Check tile bounds
            int tilesX = (int)Math.Ceiling((double)levelWidth / tileSize);
            int tilesY = (int)Math.Ceiling((double)levelHeight / tileSize);

            if (col >= tilesX || row >= tilesY || col < 0 || row < 0)
                return NotFound("Tile out of bounds");

            // Calculate the region in the original image that this tile represents
            double invScale = Math.Pow(2, maxLevel - level);
            int srcX = (int)Math.Round(col * tileSize * invScale);
            int srcY = (int)Math.Round(row * tileSize * invScale);
            int srcW = (int)Math.Round(tileSize * invScale);
            int srcH = (int)Math.Round(tileSize * invScale);

            // Clamp to image bounds
            srcX = Math.Min(srcX, imgWidth - 1);
            srcY = Math.Min(srcY, imgHeight - 1);
            srcW = Math.Min(srcW, imgWidth - srcX);
            srcH = Math.Min(srcH, imgHeight - srcY);

            if (srcW <= 0 || srcH <= 0)
                return NotFound("Tile region empty");

            // Output tile dimensions
            int outW = Math.Min(tileSize, levelWidth - col * tileSize);
            int outH = Math.Min(tileSize, levelHeight - row * tileSize);
            outW = Math.Max(1, outW);
            outH = Math.Max(1, outH);

            // Crop and resize
            using var tile = image.Clone(ctx =>
            {
                ctx.Crop(new Rectangle(srcX, srcY, srcW, srcH));
                ctx.Resize(outW, outH);
            });

            using var outputStream = new MemoryStream();
            tile.SaveAsJpeg(outputStream, new JpegEncoder { Quality = 85 });

            var tileBytes = outputStream.ToArray();

            // Cache tile for 1 hour
            _cache.Set(tileCacheKey, tileBytes,
                new MemoryCacheEntryOptions { SlidingExpiration = TimeSpan.FromHours(1) });

            Response.Headers["Cache-Control"] = "public, max-age=86400";
            return File(tileBytes, "image/jpeg");
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error generating tile for page {PageId} level={Level} col={Col} row={Row}",
                pageId, level, col, row);
            return StatusCode(500, "Error generating tile");
        }
    }

    /// <summary>
    /// Uploads a new document page with enhanced security validation
    /// </summary>
    /// <param name="documentId">Document ID</param>
    /// <param name="pageNumber">Page number</param>
    /// <param name="file">File to upload</param>
    /// <param name="pageReference">Optional page reference</param>
    /// <returns>Upload result with page ID</returns>
    [HttpPost("upload/{documentId:int}/{pageNumber:int}")]
    [Authorize(Policy = "CanUploadDocuments")]
    public async Task<IActionResult> UploadDocumentPage(
        int documentId, 
        int pageNumber, 
        IFormFile file, 
        string? pageReference = null)
    {
        try
        {
            if (file == null || file.Length == 0)
            {
                return BadRequest("File is required");
            }

            // Enforce project-level edit access
            var document = await _repo.GetDocumentAsync("DefaultConnection", documentId);
            if (document == null)
            {
                return NotFound("Document not found");
            }

            if (document.ProjectId.HasValue && !await _repo.HasProjectEditAccessAsync(User, document.ProjectId.Value))
            {
                _logger.LogWarning("User {User} denied edit access to project {ProjectId} for upload on document {DocumentId}",
                    User.Identity?.Name, document.ProjectId, documentId);
                return Forbid();
            }

            // Resolve current user for auditing
            var currentUserId = await ResolveCurrentUserIdAsync();
            var documentPage = await _documentUploadService.UploadFileAsync(
                documentId, pageNumber, file, pageReference, currentUserId);

            _logger.LogInformation("Successfully uploaded file {FileName} for Document {DocumentId}, Page {PageNumber}",
                file.FileName, documentId, pageNumber);

            // SI-5: Generate notification for document upload
            try
            {
                await _notificationService.CreateNotificationAsync(new CreateNotificationDto
                {
                    UserId = currentUserId,
                    Title = "Document Uploaded",
                    Message = $"File '{file.FileName}' uploaded to Document {documentId}, Page {pageNumber}.",
                    Category = NotificationCategories.DocumentUpload,
                    SourceSystem = NotificationSources.Api,
                    CorrelationId = $"doc-{documentId}-page-{pageNumber}"
                });
            }
            catch (Exception notifEx)
            {
                _logger.LogWarning(notifEx, "Failed to create upload notification for Document {DocumentId}", documentId);
            }

            return Ok(new
            {
                PageId = documentPage.PageId,
                FileName = documentPage.FileName,
                FileType = documentPage.FileType,
                FileSize = documentPage.FileSize,
                ContentType = documentPage.ContentType,
                UploadedDate = documentPage.UploadedDate,
                ViewUrl = Url.Action(nameof(GetDocumentPage), new { pageId = documentPage.PageId }),
                DownloadUrl = Url.Action(nameof(DownloadDocumentPage), new { pageId = documentPage.PageId })
            });
        }
        catch (ArgumentException ex)
        {
            _logger.LogWarning("File upload validation failed for Document {DocumentId}: {Error}", 
                documentId, ex.Message);
            return BadRequest(ex.Message);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error uploading file for Document {DocumentId}, Page {PageNumber}", 
                documentId, pageNumber);
            return StatusCode(500, "Error uploading file");
        }
    }

    private async Task<int> ResolveCurrentUserIdAsync()
    {
        try
        {
            var authState = await _authenticationStateProvider.GetAuthenticationStateAsync();
            var username = authState.User?.Identity?.Name;
            if (!string.IsNullOrEmpty(username))
            {
                using var secCtx = await _securityDbContextFactory.CreateDbContextAsync();
                var user = await secCtx.Users.FirstOrDefaultAsync(u => u.Username == username);
                if (user != null)
                    return user.UserId;
            }
        }
        catch
        {
            // Ignore
        }

        return 0;
    }
}



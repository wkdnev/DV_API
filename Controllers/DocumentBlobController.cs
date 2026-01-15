using DV.API.Data;
using DV.API.Data;
using DV.API.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Formats.Jpeg;
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
    private readonly ILogger<DocumentBlobController> _logger;
    private readonly IDbContextFactory<SecurityDbContext> _securityDbContextFactory;
    private readonly AuthenticationStateProvider _authenticationStateProvider;

    public DocumentBlobController(DocumentUploadService documentUploadService, ILogger<DocumentBlobController> logger,
        IDbContextFactory<SecurityDbContext> securityDbContextFactory, AuthenticationStateProvider authenticationStateProvider)
    {
        _documentUploadService = documentUploadService;
        _logger = logger;
        _securityDbContextFactory = securityDbContextFactory;
        _authenticationStateProvider = authenticationStateProvider;
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

            // Resolve current user for auditing
            var currentUserId = await ResolveCurrentUserIdAsync();
            var documentPage = await _documentUploadService.UploadFileAsync(
                documentId, pageNumber, file, pageReference, currentUserId);

            _logger.LogInformation("Successfully uploaded file {FileName} for Document {DocumentId}, Page {PageNumber}",
                file.FileName, documentId, pageNumber);

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



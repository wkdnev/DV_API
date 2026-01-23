// ============================================================================
// DocumentController.cs - API Controller for Document Viewer Application
// ============================================================================
//
// Purpose: Provides API endpoints for retrieving and processing document files 
// (PDF and TIFF) and their metadata. This controller interacts with the 
// DocumentRepository to fetch data and serves files to the client.
//
// Created: [Date]
// Last Updated: [Date]
//
// Dependencies:
// - DocumentRepository: Handles database interactions for documents and pages.
// - SixLabors.ImageSharp: Used for image processing (e.g., TIFF to JPEG conversion).
// - ASP.NET Core MVC: Provides the base for API controller functionality.
// ============================================================================

using DV.Shared.Models; // Imports models like Document and DocumentPage
using DV.API.Services; // Imports the DocumentRepository service
using DV.Shared.Security; // Imports security models and services
using Microsoft.AspNetCore.Mvc; // Provides MVC functionality for API controllers
using Microsoft.AspNetCore.Authorization; // Provides authorization attributes
using System.IO; // Provides file system operations
using System.Linq; // Enables LINQ operations
using System.Threading.Tasks; // Enables asynchronous programming
using SixLabors.ImageSharp; // Library for image processing
using SixLabors.ImageSharp.Formats.Jpeg; // JPEG encoder for image conversion
using System.Security.Claims; // Provides access to user claims

namespace DV.API.Controllers;

// ============================================================================
// DocumentController Class
// ============================================================================
// Purpose: Defines API endpoints for retrieving and processing document files.
// Inherits: ControllerBase (ASP.NET Core MVC base class for API controllers).
// ============================================================================
[ApiController]
[Route("api")]
[Authorize] // Require authentication for all endpoints
public class DocumentController : ControllerBase
{
    private readonly DocumentRepository _repo; // Repository for database operations
    private readonly UserService _userService; // Service for user operations
    private readonly AuditService _auditService; // Service for audit logging

    // ========================================================================
    // Constructor: DocumentController
    // ========================================================================
    // Purpose: Initializes the controller with required services.
    // Parameters:
    // - repo: An instance of DocumentRepository for database interactions.
    // - userService: Service for user-related operations.
    // - auditService: Service for audit logging.
    public DocumentController(
        DocumentRepository repo, 
        UserService userService, 
        AuditService auditService)
    {
        _repo = repo;
        _userService = userService;
        _auditService = auditService;
    }

    // ========================================================================
    // Helper Method: ValidateProjectAccessAsync
    // ========================================================================
    // Purpose: Validates that the current user has access to the specified document's project.
    // Parameters:
    // - database: The database name.
    // - documentId: The document ID to check access for.
    // Returns: A tuple containing (isValid, document, errorMessage).
    private async Task<(bool isValid, Document? document, string? errorMessage)> ValidateProjectAccessAsync(string database, int documentId)
    {
        try
        {
            // Get current user from claims
            var username = User.Identity?.Name;
            if (string.IsNullOrEmpty(username))
            {
                return (false, null, "User not authenticated");
            }

            // Get document to check project access
            var document = await _repo.GetDocumentAsync(database, documentId);
            if (document == null)
            {
                return (false, null, "Document not found");
            }

            // Check if Global Admin (Bypass project check)
            if (User.IsInRole("DV_Global_Admins") || User.HasClaim(c => (c.Type == "groups" || c.Type == "http://schemas.microsoft.com/ws/2008/06/identity/claims/groups") && c.Value == "DV_Global_Admins"))
            {
                return (true, document, null);
            }

            // For non-admin users, validate project access
            if (!document.ProjectId.HasValue)
            {
                // If no project assigned, maybe only generic access? Assuming no access for now unless Admin.
                 return (false, document, "Document is not associated with a project");
            }
            
            var hasAccess = await _repo.HasProjectAccessAsync(User, document.ProjectId.Value);
            if (!hasAccess)
            {
                return (false, document, "You do not have permission to access documents from this project");
            }

            return (true, document, null); // User has valid access
        }
        catch (Exception ex)
        {
            return (false, null, $"Error validating access: {ex.Message}");
        }
    }

    private async Task<(bool isValid, Document? document, string? errorMessage)> ValidateProjectAccessAsync(string database, string schema, int documentId)
    {
        try
        {
             // Get current user from claims
            var username = User.Identity?.Name;
            if (string.IsNullOrEmpty(username))
            {
                return (false, null, "User not authenticated");
            }

            // Get document to check project access - USING SCHEMA
            var document = await _repo.GetDocumentAsync(database, schema, documentId);
            if (document == null)
            {
                return (false, null, "Document not found");
            }

            // Check if Global Admin (Bypass project check)
            if (User.IsInRole("DV_Global_Admins") || User.HasClaim(c => (c.Type == "groups" || c.Type == "http://schemas.microsoft.com/ws/2008/06/identity/claims/groups") && c.Value == "DV_Global_Admins"))
            {
                return (true, document, null);
            }

            // For non-admin users, validate project access
            if (!document.ProjectId.HasValue)
            {
                return (false, document, "Document is not associated with a project");
            }

            var hasAccess = await _repo.HasProjectAccessAsync(User, document.ProjectId.Value);
            if (!hasAccess)
            {
                 return (false, document, "You do not have permission to access documents from this project");
            }

            return (true, document, null); // User has valid access
        }
        catch (Exception ex)
        {
             return (false, null, $"Error validating access: {ex.Message}");
        }
    }

    // - documentId: The ID of the document to retrieve.
    // Returns: IActionResult containing the PDF file or an error message.
    [HttpGet("pdf/{documentId:int}")]
    [HttpGet("pdf-view/{documentId:int}")]
    [HttpGet("pdf/{schema}/{documentId:int}")]
    [HttpGet("pdf-view/{schema}/{documentId:int}")]
    public async Task<IActionResult> GetPdf(int documentId, string? schema = null)
    {
        // Default "database" value for internal calls if needed, though most signatures will just ignore it now.
        const string database = "DefaultConnection";

        var username = User.Identity?.Name ?? "Unknown";
        ApplicationUser? currentUser = null;
        
        try
        {
            // Validate user has access to this document's project
            var validationResult = !string.IsNullOrEmpty(schema) 
                ? await ValidateProjectAccessAsync(database, schema, documentId)
                : await ValidateProjectAccessAsync(database, documentId);
                
            var isValid = validationResult.isValid;
            var document = validationResult.document;
            var errorMessage = validationResult.errorMessage;
            
            // Get current user for audit logging
            if (!string.IsNullOrEmpty(username))
            {
                currentUser = await _userService.GetUserByUsernameAsync(username);
            }
            
            if (!isValid)
            {
                // Log the access denial
                await _auditService.LogDocumentAccessDeniedAsync(
                    username,
                    currentUser?.UserId,
                    documentId,
                    document?.ProjectId ?? 0,
                    errorMessage ?? "Access denied",
                    document?.Title);

                if (errorMessage == "Document not found")
                    return NotFound("Document not found.");
                
                return Forbid(errorMessage ?? "Access denied");
            }

            if (document == null || string.IsNullOrWhiteSpace(document.FilePath))
            {
                await _auditService.LogDocumentAccessDeniedAsync(
                    username,
                    currentUser?.UserId,
                    documentId,
                    0,
                    "Document not found or file path missing");
                    
                return NotFound("Document not found or file path is missing.");
            }

            if (!System.IO.File.Exists(document.FilePath))
            {
                await _auditService.LogDocumentAccessDeniedAsync(
                    username,
                    currentUser?.UserId,
                    documentId,
                    document.ProjectId,
                    "PDF file does not exist on disk",
                    document.Title);
                    
                return NotFound($"PDF file does not exist at path: {document.FilePath}");
            }

            // Log successful access
            await _auditService.LogDocumentAccessAsync(
                username,
                currentUser?.UserId,
                documentId,
                document.ProjectId,
                AuditActions.ViewDocument,
                document.Title);

            var fileBytes = System.IO.File.ReadAllBytes(document.FilePath);
            return File(fileBytes, "application/pdf");
        }
        catch (Exception ex)
        {
            // Log the error
            await _auditService.LogSecurityEventAsync(
                username,
                currentUser?.UserId,
                "PDF_ACCESS_ERROR",
                $"Error retrieving PDF {documentId}: {ex.Message}",
                documentId: documentId);
                
            return StatusCode(500, $"Error retrieving PDF: {ex.Message}");
        }
    }

    // ========================================================================
    // Endpoint: GetTiffPage
    // ========================================================================
    // Purpose: Retrieves a specific page of a TIFF document from the file system 
    // and serves it to the client. Validates user has access to the document's project.
    // Route: GET /api/tiff/{database}/{documentId:int}/{pageNumber:int}
    // Parameters:
    // - database: The name of the database to query.
    // - documentId: The ID of the document to retrieve.
    // - pageNumber: The page number of the TIFF document to retrieve.
    // Returns: IActionResult containing the TIFF file or an error message.
    [HttpGet("tiff/{documentId:int}/{pageNumber:int}")]
    [HttpGet("tiff/{schema}/{documentId:int}/{pageNumber:int}")]
    public async Task<IActionResult> GetTiffPage(int documentId, int pageNumber, string? schema = null)
    {
        const string database = "DefaultConnection";
        var username = User.Identity?.Name ?? "Unknown";
        ApplicationUser? currentUser = null;
        
        try
        {
            // Validate user has access to this document's project
            var validationResult = !string.IsNullOrEmpty(schema) 
                ? await ValidateProjectAccessAsync(database, schema, documentId)
                : await ValidateProjectAccessAsync(database, documentId);
                
            var isValid = validationResult.isValid;
            var document = validationResult.document;
            var errorMessage = validationResult.errorMessage;

            
            // Get current user for audit logging
            if (!string.IsNullOrEmpty(username))
            {
                currentUser = await _userService.GetUserByUsernameAsync(username);
            }
            
            if (!isValid)
            {
                // Log the access denial
                await _auditService.LogDocumentAccessDeniedAsync(
                    username,
                    currentUser?.UserId,
                    documentId,
                    document?.ProjectId ?? 0,
                    errorMessage ?? "Access denied",
                    document?.Title);

                if (errorMessage == "Document not found")
                    return NotFound($"Document not found for ID: {documentId}");
                
                return Forbid(errorMessage ?? "Access denied");
            }

            var pages = !string.IsNullOrEmpty(schema)
                ? (await _repo.GetPagesAsync(database, schema, documentId)).ToList()
                : (await _repo.GetPagesAsync(database, documentId)).ToList();

            if (pages == null || !pages.Any())
            {
                await _auditService.LogDocumentAccessDeniedAsync(
                    username,
                    currentUser?.UserId,
                    documentId,
                    document!.ProjectId,
                    "No pages found for document",
                    document.Title);
                    
                return NotFound($"No pages found for document ID: {documentId}");
            }

            var documentpage = pages.FirstOrDefault(p => p.PageNumber == pageNumber);

            if (documentpage == null || string.IsNullOrWhiteSpace(documentpage.FilePath))
            {
                await _auditService.LogDocumentAccessDeniedAsync(
                    username,
                    currentUser?.UserId,
                    documentId,
                    document!.ProjectId,
                    $"Page {pageNumber} not found or file path missing",
                    document.Title);
                    
                return NotFound($"DocumentPage {pageNumber} not found or file path is missing for document ID: {documentId}");
            }

            if (!System.IO.File.Exists(documentpage.FilePath))
            {
                await _auditService.LogDocumentAccessDeniedAsync(
                    username,
                    currentUser?.UserId,
                    documentId,
                    document!.ProjectId,
                    "TIFF file does not exist on disk",
                    document.Title);
                    
                return NotFound($"TIFF file does not exist at path: {documentpage.FilePath}");
            }

            // Log successful access
            await _auditService.LogDocumentAccessAsync(
                username,
                currentUser?.UserId,
                documentId,
                document!.ProjectId,
                AuditActions.DownloadDocument,
                $"{document.Title} (Page {pageNumber})");

            var fileBytes = System.IO.File.ReadAllBytes(documentpage.FilePath);
            return File(fileBytes, "image/tiff");
        }
        catch (Exception ex)
        {
            // Log the error
            await _auditService.LogSecurityEventAsync(
                username,
                currentUser?.UserId,
                "TIFF_ACCESS_ERROR",
                $"Error retrieving TIFF {documentId} page {pageNumber}: {ex.Message}",
                documentId: documentId);
                
            return StatusCode(500, $"Error retrieving TIFF: {ex.Message}");
        }
    }

    // ========================================================================
    // Endpoint: ViewTiffPage
    // ========================================================================
    // Purpose: Converts a specific page of a TIFF document to JPEG format and 
    // serves it to the client for browser viewing. Validates user has access to the document's project.
    // Route: GET /api/tiff-view/{database}/{documentId:int}/{pageNumber:int}
    // Parameters:
    // - database: The name of the database to query.
    // - documentId: The ID of the document to retrieve.
    // - pageNumber: The page number of the TIFF document to convert and retrieve.
    // Returns: IActionResult containing the JPEG file or an error message.
    [HttpGet("tiff-view/{documentId:int}/{pageNumber:int}")]
    [HttpGet("tiff-view/{schema}/{documentId:int}/{pageNumber:int}")]
    public async Task<IActionResult> ViewTiffPage(int documentId, int pageNumber, string? schema = null)
    {
        const string database = "DefaultConnection";
        var username = User.Identity?.Name ?? "Unknown";
        ApplicationUser? currentUser = null;
        
        try
        {
            // Validate user has access to this document's project
            var validationResult = !string.IsNullOrEmpty(schema) 
                ? await ValidateProjectAccessAsync(database, schema, documentId)
                : await ValidateProjectAccessAsync(database, documentId);
                
            var isValid = validationResult.isValid;
            var document = validationResult.document;
            var errorMessage = validationResult.errorMessage;

            
            // Get current user for audit logging
            if (!string.IsNullOrEmpty(username))
            {
                currentUser = await _userService.GetUserByUsernameAsync(username);
            }
            
            if (!isValid)
            {
                // Log the access denial
                await _auditService.LogDocumentAccessDeniedAsync(
                    username,
                    currentUser?.UserId,
                    documentId,
                    document?.ProjectId ?? 0,
                    errorMessage ?? "Access denied",
                    document?.Title);

                if (errorMessage == "Document not found")
                    return NotFound($"Document not found for ID: {documentId}");
                
                return Forbid(errorMessage ?? "Access denied");
            }

            var pages = !string.IsNullOrEmpty(schema)
                ? (await _repo.GetPagesAsync(database, schema, documentId)).ToList()
                : (await _repo.GetPagesAsync(database, documentId)).ToList();

            if (pages == null || !pages.Any())
            {
                await _auditService.LogDocumentAccessDeniedAsync(
                    username,
                    currentUser?.UserId,
                    documentId,
                    document!.ProjectId,
                    "No pages found for document",
                    document.Title);
                    
                return NotFound($"No pages found for document ID: {documentId}");
            }

            var documentpage = pages.FirstOrDefault(p => p.PageNumber == pageNumber);

            if (documentpage == null || string.IsNullOrWhiteSpace(documentpage.FilePath))
            {
                await _auditService.LogDocumentAccessDeniedAsync(
                    username,
                    currentUser?.UserId,
                    documentId,
                    document!.ProjectId,
                    $"Page {pageNumber} not found or file path missing",
                    document.Title);
                    
                return NotFound($"DocumentPage {pageNumber} not found or file path is missing for document ID: {documentId}");
            }

            if (!System.IO.File.Exists(documentpage.FilePath))
            {
                await _auditService.LogDocumentAccessDeniedAsync(
                    username,
                    currentUser?.UserId,
                    documentId,
                    document!.ProjectId,
                    "TIFF file does not exist on disk",
                    document.Title);
                    
                return NotFound($"TIFF file does not exist at path: {documentpage.FilePath}");
            }

            try
            {
                // Log successful access
                await _auditService.LogDocumentAccessAsync(
                    username,
                    currentUser?.UserId,
                    documentId,
                    document!.ProjectId,
                    AuditActions.ViewDocument,
                    $"{document.Title} (Page {pageNumber} as JPEG)");

                // Use SkiaSharp instead of ImageSharp to convert TIFF to JPEG
                using var inputStream = new FileStream(documentpage.FilePath, FileMode.Open, FileAccess.Read);
                using var skBitmap = SkiaSharp.SKBitmap.Decode(inputStream);
                using var image = SkiaSharp.SKImage.FromBitmap(skBitmap);
                
                // Encode as JPEG with quality 90
                var jpegData = image.Encode(SkiaSharp.SKEncodedImageFormat.Jpeg, 90);
                
                // Get the bytes and return them
                var bytes = jpegData.ToArray();
                return File(bytes, "image/jpeg");
            }
            catch (Exception ex)
            {
                // Log the conversion error
                await _auditService.LogSecurityEventAsync(
                    username,
                    currentUser?.UserId,
                    "TIFF_CONVERSION_ERROR",
                    $"Error converting TIFF {documentId} page {pageNumber} to JPEG: {ex.Message}",
                    document!.ProjectId,
                    documentId);
                    
                return StatusCode(500, $"Error converting TIFF to JPEG: {ex.Message}");
            }
        }
        catch (Exception ex)
        {
            // Log the error
            await _auditService.LogSecurityEventAsync(
                username,
                currentUser?.UserId,
                "TIFF_VIEW_ERROR",
                $"Error retrieving TIFF view {documentId} page {pageNumber}: {ex.Message}",
                documentId: documentId);
                
            return StatusCode(500, $"Error retrieving image: {ex.Message}");
        }
    }
}

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using DV.Shared.Constants;
using DV.Shared.Interfaces;
using DV.Shared.Security;
using DV.API.Services;

namespace DV.API.Controllers;

/// <summary>
/// Issues JWT tokens for internal (non-AD FS) authentication mode.
/// Only active when Auth:Mode = "Internal".
/// </summary>
[ApiController]
[Route("api/auth")]
public class TokenController : ControllerBase
{
    private readonly IConfiguration _configuration;
    private readonly ICredentialService _credentialService;
    private readonly UserService _userService;
    private readonly AuditService _auditService;

    public TokenController(
        IConfiguration configuration,
        ICredentialService credentialService,
        UserService userService,
        AuditService auditService)
    {
        _configuration = configuration;
        _credentialService = credentialService;
        _userService = userService;
        _auditService = auditService;
    }

    /// <summary>
    /// Authenticate with username/password and receive a JWT token.
    /// Only available when Auth:Mode = "Internal".
    /// </summary>
    [HttpPost("token")]
    [AllowAnonymous]
    public async Task<IActionResult> GetToken([FromBody] TokenRequest request)
    {
        var authMode = _configuration["Auth:Mode"] ?? "ADFS";
        if (!authMode.Equals("Internal", StringComparison.OrdinalIgnoreCase))
        {
            return BadRequest(new { error = "Token endpoint is only available in Internal auth mode" });
        }

        if (string.IsNullOrEmpty(request.Username) || string.IsNullOrEmpty(request.Password))
        {
            return BadRequest(new { error = "Username and password are required" });
        }

        // Validate local credentials
        var user = await _credentialService.ValidateCredentialAsync(request.Username, request.Password);
        if (user == null)
        {
            // NIST AU-2: Log failed authentication attempt
            await _auditService.LogAuthenticationAsync(
                request.Username, AuditActions.LoginFailed, AuditResults.Failed,
                "Invalid username or password via API token endpoint");
            return Unauthorized(new { error = "Invalid username or password" });
        }

        // Build claims
        var claims = new List<Claim>
        {
            new Claim("unique_name", user.Username),
            new Claim(System.Security.Claims.ClaimTypes.Name, user.Username),
            new Claim("user_id", user.UserId.ToString()),
            new Claim("auth_method", "internal_jwt")
        };

        // Add role claims from database
        try
        {
            var isGlobalAdmin = await _userService.IsGlobalAdminAsync(user.Username);
            if (isGlobalAdmin)
            {
                claims.Add(new Claim("role", Roles.GlobalAdminGroup));
            }

            // Get user's project roles
            var roles = await _userService.GetUserRolesAsync(user.UserId);
            foreach (var role in roles)
            {
                if (!claims.Any(c => c.Type == "role" && c.Value == role.Name))
                {
                    claims.Add(new Claim("role", role.Name));
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Warning: Could not load roles for {user.Username}: {ex.Message}");
        }

        // Generate JWT
        var signingKey = _configuration["Jwt:SigningKey"]
            ?? throw new InvalidOperationException("Jwt:SigningKey not configured");
        var issuer = _configuration["Jwt:Issuer"] ?? "DocViewer";
        var audience = _configuration["Jwt:Audience"] ?? "docviewer-api";
        var expiryMinutes = int.TryParse(_configuration["Jwt:ExpiryMinutes"], out var mins) ? mins : 480;

        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(signingKey));
        var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

        var token = new JwtSecurityToken(
            issuer: issuer,
            audience: audience,
            claims: claims,
            expires: DateTime.UtcNow.AddMinutes(expiryMinutes),
            signingCredentials: credentials
        );

        var tokenString = new JwtSecurityTokenHandler().WriteToken(token);

        // NIST AU-2: Log successful authentication
        await _auditService.LogAuthenticationAsync(
            user.Username, AuditActions.Login, AuditResults.Success,
            "JWT token issued via API token endpoint");

        return Ok(new
        {
            access_token = tokenString,
            token_type = "Bearer",
            expires_in = expiryMinutes * 60,
            username = user.Username
        });
    }
}

public class TokenRequest
{
    public string Username { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
}

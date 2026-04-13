// ============================================================================
// Program.cs - Entry Point for DV.API (Document Viewer API)
// ============================================================================

using DV.API.Data;
using DV.API.Services;
using DV.API.Middleware;
using DV.API.Security;
using DV.API.Infrastructure.Caching;
using DV.API.Infrastructure.ErrorHandling;
using DV.API.Infrastructure.Validation;
using DV.API.Infrastructure.Configuration;
using DV.API.Infrastructure.HealthChecks;
using DV.Shared.Models;
using DV.Shared.Security;
using DV.Shared.Interfaces;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Options;
using System.Security.Claims;
using System.Text;
using DV.Shared.Constants;

var builder = WebApplication.CreateBuilder(args);

// ============================================================================
// Configuration Setup
// ============================================================================
builder.Services.Configure<AppSettings>(builder.Configuration.GetSection("AppSettings"));

// ============================================================================
// Logging Configuration
// ============================================================================
builder.Logging.ClearProviders();
builder.Logging.AddConsole();
builder.Logging.AddDebug();
builder.Logging.SetMinimumLevel(LogLevel.Information);

// ============================================================================
// Infrastructure Services
// ============================================================================
builder.Services.AddGlobalErrorHandling();
builder.Services.AddMemoryCache();
builder.Services.AddScoped<ICacheService, MemoryCacheService>();
builder.Services.AddScoped<IValidationService, ValidationService>();
builder.Services.AddScoped<IInputValidationService, InputValidationService>();

// ============================================================================
// Database Configuration
// ============================================================================

// Register AppDbContext for document data
builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseNpgsql(
        builder.Configuration.GetConnectionString("DefaultConnection"),
        npgsqlOptions => {
            npgsqlOptions.EnableRetryOnFailure(maxRetryCount: 5);
            npgsqlOptions.CommandTimeout(30);
        }
    );

    if (builder.Environment.IsDevelopment())
    {
        options.EnableSensitiveDataLogging();
        options.EnableDetailedErrors();
    }
});

// Register SecurityDbContext for security data
builder.Services.AddDbContext<SecurityDbContext>(options =>
{
    options.UseNpgsql(
        builder.Configuration.GetConnectionString("DefaultConnection"),
        npgsqlOptions => {
            npgsqlOptions.EnableRetryOnFailure(maxRetryCount: 5);
            npgsqlOptions.CommandTimeout(30);
        }
    );

    if (builder.Environment.IsDevelopment())
    {
        options.EnableSensitiveDataLogging();
        options.EnableDetailedErrors();
    }
});

// ============================================================================
// Authentication Configuration
// ============================================================================
var authMode = builder.Configuration["Auth:Mode"] ?? "ADFS";
var isInternalAuth = authMode.Equals("Internal", StringComparison.OrdinalIgnoreCase);

if (builder.Environment.IsDevelopment())
{
    // Development: bypass AD FS, auto-authenticate as dev user
    builder.Services.AddAuthentication("DevAuth")
        .AddScheme<AuthenticationSchemeOptions, DevAuthenticationHandler>("DevAuth", null);
    Console.WriteLine("*** DEVELOPMENT MODE: Authentication bypassed — auto-authenticating as AD\\neil.rainsforth ***");
}
else if (isInternalAuth)
{
    // Internal mode: validate JWTs signed with a local symmetric key
    var signingKey = builder.Configuration["Jwt:SigningKey"] 
        ?? throw new InvalidOperationException("Jwt:SigningKey must be configured for Internal auth mode");
    var issuer = builder.Configuration["Jwt:Issuer"] ?? "DocViewer";
    var audience = builder.Configuration["Jwt:Audience"] ?? "docviewer-api";

    builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
        .AddJwtBearer(options =>
        {
            options.TokenValidationParameters = new TokenValidationParameters
            {
                ValidateIssuer = true,
                ValidIssuer = issuer,
                ValidateAudience = true,
                ValidAudience = audience,
                ValidateLifetime = true,
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(signingKey)),
                ClockSkew = TimeSpan.FromMinutes(5),
                RoleClaimType = "role",
                NameClaimType = "unique_name"
            };
        });
    Console.WriteLine("*** AUTH MODE: Internal — using local JWT token validation ***");
}
else
{
    var adfsAuthority = builder.Configuration["Adfs:Authority"];
    var adfsMetadata = builder.Configuration["Adfs:MetadataAddress"];
    var validAudiences = builder.Configuration.GetSection("Adfs:ValidAudiences").Get<string[]>() ?? new[] { "blazor-api" };

    builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
        .AddJwtBearer(options =>
        {
            options.Authority = adfsAuthority;
            options.MetadataAddress = adfsMetadata;
            options.RequireHttpsMetadata = true;
            options.TokenValidationParameters = new TokenValidationParameters
            {
                ValidateIssuer = true,
                ValidIssuer = adfsAuthority,
                ValidateAudience = true,
                ValidAudiences = validAudiences,
                ValidateLifetime = true,
                ClockSkew = TimeSpan.FromMinutes(5),
                RoleClaimType = "role",
                NameClaimType = "unique_name"
            };
        });
    Console.WriteLine("*** AUTH MODE: ADFS — using AD FS JWT Bearer validation ***");
}

// Authorization with GlobalAdmin support
builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("RequireGlobalAdmin", policy =>
        policy.Requirements.Add(new GlobalAdminRequirement()));
        
    options.AddPolicy("CanUploadDocuments", policy =>
        policy.RequireRole(Roles.AdminGroup, Roles.GlobalAdminGroup));
});
builder.Services.AddScoped<IAuthorizationHandler, GlobalAdminAuthorizationHandler>();

// ============================================================================
// Service Registration
// ============================================================================

// Core services
builder.Services.AddScoped<UserService>();
builder.Services.AddScoped<ProjectService>();
builder.Services.AddScoped<SchemaService>();
builder.Services.AddScoped<ProjectRoleService>();
builder.Services.AddScoped<DocumentRepository>();
builder.Services.AddScoped<DocumentUploadService>();
builder.Services.AddScoped<DocumentUploadResultService>();
builder.Services.AddScoped<AuditService>();
builder.Services.AddScoped<SessionManagementService>();
builder.Services.AddTransient<ICredentialService, CredentialService>(); // NIST SP 800-53: Local credential management
builder.Services.AddTransient<IAccessGroupService, AccessGroupService>(); // App-managed access groups
builder.Services.AddScoped<NotificationService>();
builder.Services.AddScoped<FirstUserAdminService>();
// builder.Services.AddScoped<UserProjectAccessService>();
builder.Services.AddScoped<SchemaBlobMigrationService>();
builder.Services.AddScoped<FileUploadSecurityService>();
builder.Services.AddScoped<DatabaseMigrationService>();

// Security services (from DV.API.Security namespace)
builder.Services.AddScoped<DV.API.Security.RoleService>();

// Hosted services
builder.Services.AddHostedService<SessionCleanupService>();

// Bulk Export background processing
builder.Services.AddSingleton<IExportTaskQueue, ExportTaskQueue>();
builder.Services.AddSingleton<BulkExportService>();
builder.Services.AddHostedService<ExportBackgroundService>();

// ============================================================================
// Session Configuration (NIST SP 800-53 AC-12 compliant)
// ============================================================================
builder.Services.AddDistributedMemoryCache();
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(SessionConfig.IdleTimeoutMinutes);
    options.Cookie.Name = SessionConfig.CookieName;
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
    options.Cookie.SameSite = SameSiteMode.Strict;
    options.Cookie.SecurePolicy = CookieSecurePolicy.SameAsRequest;
});

// ============================================================================
// API Configuration
// ============================================================================
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new() { Title = "DocViewer API", Version = "v1" });
    c.AddSecurityDefinition("Bearer", new Microsoft.OpenApi.OpenApiSecurityScheme
    {
        Description = "JWT Authorization header using the Bearer scheme",
        Name = "Authorization",
        In = Microsoft.OpenApi.ParameterLocation.Header,
        Type = Microsoft.OpenApi.SecuritySchemeType.ApiKey,
        Scheme = "Bearer"
    });
    c.AddSecurityRequirement(_ => new Microsoft.OpenApi.OpenApiSecurityRequirement
    {
        {
            new Microsoft.OpenApi.OpenApiSecuritySchemeReference("Bearer"),
            new List<string>()
        }
    });
});

// ============================================================================
// CORS Configuration
// ============================================================================
var corsOrigins = builder.Configuration.GetSection("Cors:AllowedOrigins").Get<string[]>() ?? Array.Empty<string>();
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowBlazorApp", policy =>
    {
        policy.WithOrigins(corsOrigins)
              .AllowAnyHeader()
              .AllowAnyMethod()
              .AllowCredentials();
    });
});

// Health checks
builder.Services.AddHealthChecks()
    .AddCheck<DatabaseHealthCheck>("database")
    .AddCheck<ApplicationHealthCheck>("application");

builder.Services.AddHttpContextAccessor();

var app = builder.Build();

// ============================================================================
// Middleware Pipeline
// ============================================================================
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "DocViewer API v1"));
}

app.UseHttpsRedirection();
app.UseCors("AllowBlazorApp");

// Security middleware
app.UseMiddleware<SecurityHeadersMiddleware>();
app.UseMiddleware<RequestResponseLoggingMiddleware>();

app.UseAuthentication();

// Session middleware (must be before session tracking)
app.UseSession();

// Session Tracking (Must run after Auth so User is populated)
app.UseMiddleware<SessionTrackingMiddleware>();

app.UseAuthorization();

// Role Enforcement (Enforces session validity)
app.UseMiddleware<RoleEnforcementMiddleware>();

app.MapControllers();
app.MapHealthChecks("/health");

// Database schema migration + PublicToken backfill
try
{
    using var scope = app.Services.CreateScope();
    var migrationService = scope.ServiceProvider.GetRequiredService<DatabaseMigrationService>();
    if (await migrationService.CheckIfMigrationNeededAsync())
    {
        Console.WriteLine("Running schema migrations...");
        await migrationService.ExecuteProjectSchemaMigrationAsync();
        Console.WriteLine("Schema migrations completed.");
    }

    // Migrate per-project schema tables (adds new columns like PublicToken)
    var schemaService = scope.ServiceProvider.GetRequiredService<SchemaService>();
    await schemaService.MigrateAllExistingSchemasAsync();

    var repo = scope.ServiceProvider.GetRequiredService<DocumentRepository>();
    var backfilled = await repo.BackfillDocumentTokensAsync();
    if (backfilled > 0)
        Console.WriteLine($"Backfilled PublicToken for {backfilled} documents.");
}
catch (Exception ex)
{
    Console.WriteLine($"Error during schema migration/backfill: {ex.Message}");
}

app.Run();

// =============================================================================
// Development-only authentication handler (bypasses AD FS)
// =============================================================================
public class DevAuthenticationHandler : AuthenticationHandler<AuthenticationSchemeOptions>
{
    public DevAuthenticationHandler(
        IOptionsMonitor<AuthenticationSchemeOptions> options,
        ILoggerFactory logger,
        System.Text.Encodings.Web.UrlEncoder encoder)
        : base(options, logger, encoder) { }

    protected override Task<AuthenticateResult> HandleAuthenticateAsync()
    {
        // Check if the calling UI app forwarded the actual user's identity
        var forwardedUser = Request.Headers["X-Forwarded-User"].FirstOrDefault();
        var username = !string.IsNullOrEmpty(forwardedUser) ? forwardedUser : @"AD\neil.rainsforth";

        var claims = new[]
        {
            new Claim("unique_name", username),
            new Claim(System.Security.Claims.ClaimTypes.Name, username),
            new Claim("role", Roles.GlobalAdminGroup),
            new Claim("role", Roles.AdminGroup),
            new Claim("role", Roles.AuditorGroup),
            new Claim("role", Roles.SecurityGroup),
            new Claim("groups", Roles.GlobalAdminGroup),
            new Claim("auth_method", "dev_bypass"),
        };
        var identity = new ClaimsIdentity(claims, "DevAuth", "unique_name", "role");
        var principal = new ClaimsPrincipal(identity);
        var ticket = new AuthenticationTicket(principal, "DevAuth");
        return Task.FromResult(AuthenticateResult.Success(ticket));
    }
}

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
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.AspNetCore.Authorization;
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
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("DefaultConnection"),
        sqlOptions => {
            sqlOptions.EnableRetryOnFailure(maxRetryCount: 5);
            sqlOptions.CommandTimeout(30);
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
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("DefaultConnection"),
        sqlOptions => {
            sqlOptions.EnableRetryOnFailure(maxRetryCount: 5);
            sqlOptions.CommandTimeout(30);
        }
    );

    if (builder.Environment.IsDevelopment())
    {
        options.EnableSensitiveDataLogging();
        options.EnableDetailedErrors();
    }
});

// ============================================================================
// Authentication Configuration (JWT from AD FS)
// ============================================================================
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
            RoleClaimType = "role", // Map 'role' claim to ClaimsPrincipal roles
            NameClaimType = "unique_name"
        };

        // For development, allow self-signed certs
        if (builder.Environment.IsDevelopment())
        {
            options.BackchannelHttpHandler = new HttpClientHandler
            {
                ServerCertificateCustomValidationCallback = (message, cert, chain, errors) => true
            };
        }
    });

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
builder.Services.AddScoped<FirstUserAdminService>();
// builder.Services.AddScoped<UserProjectAccessService>();
builder.Services.AddScoped<SchemaBlobMigrationService>();
builder.Services.AddScoped<FileUploadSecurityService>();
builder.Services.AddScoped<DatabaseMigrationService>();

// Security services (from DV.API.Security namespace)
builder.Services.AddScoped<DV.API.Security.RoleService>();

// Hosted services
builder.Services.AddHostedService<SessionCleanupService>();

// ============================================================================
// API Configuration
// ============================================================================
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new() { Title = "DocViewer API", Version = "v1" });
    c.AddSecurityDefinition("Bearer", new Microsoft.OpenApi.Models.OpenApiSecurityScheme
    {
        Description = "JWT Authorization header using the Bearer scheme",
        Name = "Authorization",
        In = Microsoft.OpenApi.Models.ParameterLocation.Header,
        Type = Microsoft.OpenApi.Models.SecuritySchemeType.ApiKey,
        Scheme = "Bearer"
    });
    c.AddSecurityRequirement(new Microsoft.OpenApi.Models.OpenApiSecurityRequirement
    {
        {
            new Microsoft.OpenApi.Models.OpenApiSecurityScheme
            {
                Reference = new Microsoft.OpenApi.Models.OpenApiReference
                {
                    Type = Microsoft.OpenApi.Models.ReferenceType.SecurityScheme,
                    Id = "Bearer"
                }
            },
            Array.Empty<string>()
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

// Session Tracking (Must run after Auth so User is populated)
app.UseMiddleware<SessionTrackingMiddleware>();

app.UseAuthorization();

// Role Enforcement (Enforces session validity)
app.UseMiddleware<RoleEnforcementMiddleware>();

app.MapControllers();
app.MapHealthChecks("/health");

app.Run();

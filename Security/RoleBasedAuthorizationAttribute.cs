using DV.API.Data;
using DV.Shared.Constants;
// ============================================================================
// RoleBasedAuthorizationAttribute.cs - Role-Based Authorization Attribute
// ============================================================================
//
// Purpose: Provides role-based authorization for Blazor components and pages.
// This attribute ensures that users can only access pages/components that 
// their current active role permits.
//
// Created: [Date]
// Last Updated: [Date]
//
// Dependencies:
// - Microsoft.AspNetCore.Authorization: For authorization infrastructure
// - DocViewer_Proto.Services: For role context management
//
// Notes:
// - Works with the RoleContextService to enforce active role permissions
// - Supports both single role and multiple role requirements
// - Integrates with existing ASP.NET Core authorization pipeline
// ============================================================================

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace DV.API.Security;

// ============================================================================
// RoleBasedAuthorizationAttribute Class
// ============================================================================
// Purpose: Attribute for marking components/pages with role-based access control.
// ============================================================================
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true)]
public class RoleBasedAuthorizationAttribute : AuthorizeAttribute
{
    public string[] RequiredRoles { get; }
    public bool RequireAllRoles { get; set; } = false;

    public RoleBasedAuthorizationAttribute(params string[] requiredRoles)
    {
        RequiredRoles = requiredRoles ?? throw new ArgumentNullException(nameof(requiredRoles));
        
        // Set the policy to a unique name that includes the roles (for the custom policy provider)
        // The policy provider will parse this to create the requirement with the correct roles
        Policy = $"RoleBasedAccess:{string.Join(",", requiredRoles)}";
    }
}

// ============================================================================
// RoleBasedAuthorizationRequirement Class
// ============================================================================
// Purpose: Authorization requirement for role-based access control.
// ============================================================================
public class RoleBasedAuthorizationRequirement : IAuthorizationRequirement
{
    public string[] RequiredRoles { get; }
    public bool RequireAllRoles { get; }

    public RoleBasedAuthorizationRequirement(string[] requiredRoles, bool requireAllRoles = false)
    {
        RequiredRoles = requiredRoles ?? throw new ArgumentNullException(nameof(requiredRoles));
        RequireAllRoles = requireAllRoles;
    }
}

// ============================================================================
// RoleBasedAuthorizationHandler Class
// ============================================================================
// Purpose: Handles role-based authorization requirements.
// ============================================================================
public class RoleBasedAuthorizationHandler : AuthorizationHandler<RoleBasedAuthorizationRequirement>
{
    private readonly ILogger<RoleBasedAuthorizationHandler> _logger;

    public RoleBasedAuthorizationHandler(
        ILogger<RoleBasedAuthorizationHandler> logger)
    {
        _logger = logger;
    }

    protected override Task HandleRequirementAsync(
        AuthorizationHandlerContext context, 
        RoleBasedAuthorizationRequirement requirement)
    {
        // Check if user is authenticated
        if (!context.User.Identity?.IsAuthenticated == true)
        {
            _logger.LogInformation("User is not authenticated");
            context.Fail();
            return Task.CompletedTask;
        }

        var username = context.User.Identity!.Name;

        _logger.LogInformation("Checking AD Group access for user '{Username}' with required roles: {RequiredRoles}",
            username, string.Join(", ", requirement.RequiredRoles ?? new string[0]));

        try
        {
            bool allRolesMet = true;
            bool anyRoleMet = false;

            foreach (var role in requirement.RequiredRoles ?? Array.Empty<string>())
            {
                // Map internal role names to AD Group names
                string groupName = role;
                if (role == Roles.Admin) groupName = Roles.AdminGroup;
                else if (role == Roles.GlobalAdmin) groupName = Roles.GlobalAdminGroup;
                else if (role == Roles.Auditor) groupName = Roles.AuditorGroup;
                else if (role == Roles.Security) groupName = Roles.SecurityGroup;

                bool hasGroup = context.User.IsInRole(groupName);
                
                if (!hasGroup)
                {
                    allRolesMet = false;
                }
                else
                {
                    anyRoleMet = true;
                }
            }

            if (requirement.RequireAllRoles)
            {
                if (allRolesMet)
                {
                    context.Succeed(requirement);
                }
                else
                {
                    context.Fail();
                }
            }
            else
            {
                if (anyRoleMet)
                {
                    context.Succeed(requirement);
                }
                else
                {
                    context.Fail();
                }
            }
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error checking AD Group authorization for user '{Username}'", username);
            context.Fail();
        }

        return Task.CompletedTask;
    }
}



using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using DV.API.Services;

using DV.Shared.Constants;

namespace DV.API.Security;

/// <summary>
/// Authorization handler that verifies if the current user is a global administrator
/// </summary>
public class GlobalAdminAuthorizationHandler : AuthorizationHandler<GlobalAdminRequirement>
{
    protected override Task HandleRequirementAsync(
        AuthorizationHandlerContext context, 
        GlobalAdminRequirement requirement)
    {
        // Check for Global Admin claim
        // We accept "GlobalAdmin" role or "DocViewer_GlobalAdmins" group/role
        if (context.User.IsInRole(Roles.GlobalAdmin) || 
            context.User.IsInRole(Roles.GlobalAdminGroup))
        {
            context.Succeed(requirement);
        }
        
        return Task.CompletedTask;
    }
}



using Microsoft.AspNetCore.Authorization;

namespace DV.API.Security;

/// <summary>
/// Authorization requirement that checks if the current user is a global admin
/// </summary>
public class GlobalAdminRequirement : IAuthorizationRequirement
{
}



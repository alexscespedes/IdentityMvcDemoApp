using System;

namespace IdentityMvcDemoApp.Models;

public class EditUserRolesViewModel
{
    public string UserId { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public List<RoleSelection> Roles { get; set; } = new();
}

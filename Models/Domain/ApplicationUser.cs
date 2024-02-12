using Microsoft.AspNetCore.Identity;

namespace Employee_Auth.Models.Domain;

public class ApplicationUser:IdentityUser
{
     public string? Name { get; set; }
}
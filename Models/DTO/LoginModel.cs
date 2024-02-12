using System.ComponentModel.DataAnnotations;

namespace Employee_Auth.Models.DTO;

public class LoginModel
{
    [Required]
    public string? Username { get; set; }
    [Required]
    public string? Email { get; set; }
    [Required]
    public string? Password { get; set; }
}
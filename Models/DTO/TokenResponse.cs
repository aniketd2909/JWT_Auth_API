namespace Employee_Auth.Models.DTO;

public class TokenResponse
{
    public string? TokenString { get; set; }
    public DateTime ValidTo { get; set; }
}
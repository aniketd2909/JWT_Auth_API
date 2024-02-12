using System.Security.Claims;
using Employee_Auth.Models.DTO;

namespace Employee_Auth.Repositories.Abstract;

public interface ITokenService
{
    TokenResponse GetToken(IEnumerable<Claim> claim);

    string GetRefreshToken();
    ClaimsPrincipal GetPrincipalFromExpiredToken(string token);
}
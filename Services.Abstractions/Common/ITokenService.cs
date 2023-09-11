using Domain.Models.Account;
using System.Security.Claims;

namespace Services.Abstractions.Common
{
    public interface ITokenService
    {
        string GenerateJwt(IEnumerable<Claim> identityInfos);
        RefreshToken ResetRefreshToken(int accountId);
        bool TryValidateAccessToken(string token, out int accountId);
    }
}

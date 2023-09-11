using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Services.Abstractions.Common;
using Services.Implementations.Account.Utils;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Domain.Extensions;
using System.Security.Cryptography;
using Domain.Models.Account;
using Services.Abstractions.Data.Repositories;
using Services.Abstractions.Extensions;

namespace Services.Implementations.Common
{
    public class TokenService : ITokenService
    {
        private readonly JwtSettings jwtSettings;
        private readonly IRefreshTokensRepository refreshTokensRepository;

        public TokenService(IOptions<JwtSettings> jwtSettings, IRefreshTokensRepository refreshTokensRepository)
        {
            this.jwtSettings = jwtSettings.Value ?? throw new ArgumentNullException(nameof(jwtSettings));
            this.refreshTokensRepository = refreshTokensRepository ?? throw new ArgumentNullException(nameof(refreshTokensRepository));
        }

        public string GenerateJwt(IEnumerable<Claim> identityInfos)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtSettings.SecretKey));
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(identityInfos),
                Expires = DateTime.UtcNow.AddMinutes(jwtSettings.JwtExpireTimeMinutes),
                SigningCredentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256),
                Issuer = jwtSettings.ValidIssuer,
                Audience = jwtSettings.ValidIssuer,
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);

            return tokenHandler.WriteToken(token);
        }

        public RefreshToken ResetRefreshToken(int accountId)
        {
            var newToken = GenerateRefreshToken();
            var rtEntity = newToken.ToEntity();
            rtEntity.UserId = accountId;
            refreshTokensRepository.DeleteByAccount(accountId);
            refreshTokensRepository.Create(rtEntity);

            return newToken;
        }

        public bool TryValidateAccessToken(string token, out int accountId)
        {
            accountId = 0;
            var validationResult = TryValidateAccessToken(token, out IEnumerable<Claim> claims);

            return validationResult && claims.TryGetValue(cl => cl.Type == "Id", out Claim idClaim)
                && int.TryParse(idClaim.Value, out accountId);
        }

        public bool TryValidateAccessToken(string token, out IEnumerable<Claim> claims)
        {
            if (token is null)
            {
                claims = default;
                return false;
            }

            var tokenHandler = new JwtSecurityTokenHandler();
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtSettings.SecretKey));

            try
            {
                tokenHandler.ValidateToken(token, new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = key,
                    ValidateIssuer = true,
                    ValidateAudience = true,
                }, out var validatedToken);

                var jwtToken = (JwtSecurityToken)validatedToken;
                claims = jwtToken.Claims;

                return true;
            }
            catch
            {
                claims = default;
                return false;
            }
        }

        private RefreshToken GenerateRefreshToken()
        {
            var rtString = Convert.ToHexString(RandomNumberGenerator.GetBytes(64));
            var isUnique = false;
            var rtTokens = refreshTokensRepository.GetAll(false);

            while (!isUnique)
            {
                if (!rtTokens.Any(rt => rt.Source == rtString))
                {
                    isUnique = true;
                }
            }

            return new RefreshToken(rtString, DateTime.UtcNow.AddDays(jwtSettings.RefreshTokenExpireTimeDays));
        }
    }
}

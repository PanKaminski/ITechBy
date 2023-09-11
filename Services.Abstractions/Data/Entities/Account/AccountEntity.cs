using Domain.Common.Enums;
using ITechBy.Domain.Common;
using Services.Abstractions.Data.Account;

namespace Services.Abstractions.Data.Entities.Account
{
    public class AccountEntity : ManagedEntity
    {
        public string Login { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string PasswordSalt { get; set; }
        public DateTime? VerificationTime { get; set; }
        public string VerificationToken { get; set; }
        public AccountStatus Status { get; set; }
        public string ResetToken { get; set; }
        public DateTime? ResetTokenExpires { get; set; }
        public DateTime? PasswordResetTime { get; set; }

        public int RefreshTokenId { get; set; }
        public RefreshTokenEntity RefreshToken { get; set; }

        public IEnumerable<RoleEntity> Roles { get; set; }
    }
}

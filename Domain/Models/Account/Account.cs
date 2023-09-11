using Domain.Common.Enums;
using ITechBy.Domain.Common;

namespace Domain.Models.Account
{
    public class Account : ManagedEntity
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

        public IEnumerable<RoleType> Roles { get; set; }

        public RefreshToken RefreshToken { get; set; }
    }
}

using Domain.Common.Enums;
using ITechBy.Domain.Common;
using Services.Abstractions.Data.Account;
using Services.Abstractions.Data.Entities.Communication;

namespace Services.Abstractions.Data.Entities.Account
{
    public class AccountEntity : ManagedEntity
    {
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string PasswordSalt { get; set; }
        public DateTime? VerificationTime { get; set; }
        public string VerificationToken { get; set; }
        public AccountStatus Status { get; set; }
        public string ResetToken { get; set; }
        public DateTime? ResetTokenExpires { get; set; }
        public DateTime? PasswordResetTime { get; set; }

        public RefreshTokenEntity RefreshToken { get; set; }
        public ICollection<RoleEntity> Roles { get; set; } = new List<RoleEntity>();
        public ICollection<ConnectionEntity> Followers { get; set; }
        public ICollection<ConnectionEntity> Following { get; set; }
        public ICollection<MessageEntity> Messages { get; set; }
        public ICollection<UserConversationEntity> Conversations { get; set; }
    }
}

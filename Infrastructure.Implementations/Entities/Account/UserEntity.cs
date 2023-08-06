using ITechBy.Domain.Common;

namespace Infrastructure.Implementations.Entities.Account
{
    public class UserEntity : ManagedEntity
    {
        public string Login { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int GenderId { get; set; }
        public GenderEntity Gender { get; set; }

        public IEnumerable<SocialLinkEntity> SocialLinks { get; set; }
        public IEnumerable<RoleEntity> Roles { get; set; }
        public IEnumerable<AchievementEntity> Achievements { get; set; }
        public IEnumerable<ConnectionEntity> PendingConnections { get; set; }
        public IEnumerable<ConnectionEntity> IncomingConnections { get; set; }
    }
}

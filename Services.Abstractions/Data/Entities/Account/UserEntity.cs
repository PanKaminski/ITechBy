using Domain.Common.Enums;
using Services.Abstractions.Data.Entities.Account;

namespace Services.Abstractions.Data.Account
{
    public class UserEntity : AccountEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public GenderType Gender { get; set; }

        public ICollection<SocialLinkEntity> SocialLinks { get; set; }
        public ICollection<AchievementEntity> Achievements { get; set; } = new List<AchievementEntity>();
    }
}

using Domain.Common.Enums;
using Services.Abstractions.Data.Entities.Account;
using Services.Abstractions.Data.Entities.Learning;

namespace Services.Abstractions.Data.Account
{
    public class UserEntity : AccountEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public GenderType Gender { get; set; }
        public string Avatar { get; set; }
        public byte Age { get; set; }

        public ICollection<SocialLinkEntity> SocialLinks { get; set; }
        public ICollection<AchievementEntity> Achievements { get; set; } = new List<AchievementEntity>();
        public ICollection<UserLanguageEntity> Languages { get; set; } = new List<UserLanguageEntity>();
    }
}

using Services.Abstractions.Data.Account;

namespace Services.Abstractions.Data.Entities.Account
{
    public class UserAchievementEntity
    {
        public int UsersId { get; set; }
        public UserEntity User { get; set; } = null!;

        public int AchievementsId { get; set; }
        public AchievementEntity Achievement { get; set; } = null!;
    }
}

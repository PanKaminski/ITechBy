using ITechBy.Domain.Common;

namespace Services.Abstractions.Data.Account
{
    public class AchievementEntity : ManagedEntity
    {
        public byte[] Picture { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public ICollection<UserEntity> Users { get; set; } = new List<UserEntity>();
    }
}
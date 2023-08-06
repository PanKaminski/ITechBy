using ITechBy.Domain.Common;

namespace Infrastructure.Implementations.Entities.Account
{
    public class AchievementEntity : ManagedEntity
    {
        public byte[] Picture { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
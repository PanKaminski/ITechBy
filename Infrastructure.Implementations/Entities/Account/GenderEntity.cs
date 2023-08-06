using Domain.Common.Enums;

namespace Infrastructure.Implementations.Entities.Account
{
    public class GenderEntity
    {
        public int Id { get; set; }
        public GenderType Type { get; set; }

        public IEnumerable<UserEntity> Users { get; set; }
    }
}

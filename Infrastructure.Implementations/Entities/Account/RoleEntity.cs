using Domain.Common.Enums;

namespace Infrastructure.Implementations.Entities.Account
{
    public class RoleEntity
    {
        public int Id { get; set; }
        public RoleType Type { get; set; }

        public IEnumerable<UserEntity> Users { get; set; }
    }
}

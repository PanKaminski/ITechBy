using Domain.Common.Enums;
using ITechBy.Domain.Common;

namespace Services.Abstractions.Data.Account
{
    public class RoleEntity : AuditableEntity
    {
        public RoleEntity() : this(RoleType.User) { }
        public RoleEntity(RoleType roleType) => Type = roleType;

        public RoleType Type { get; set; }

        public ICollection<UserEntity> Users { get; set; } = new List<UserEntity>();
    }
}

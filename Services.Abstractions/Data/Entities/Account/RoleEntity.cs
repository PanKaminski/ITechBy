using Domain.Common.Enums;
using ITechBy.Domain.Common;
using Services.Abstractions.Data.Entities.Account;

namespace Services.Abstractions.Data.Account
{
    public class RoleEntity : AuditableEntity
    {
        public RoleEntity() : this(RoleType.User) { }
        public RoleEntity(RoleType roleType) => Type = roleType;

        public RoleType Type { get; set; }

        public IEnumerable<AccountEntity> Accounts { get; set; }
    }
}

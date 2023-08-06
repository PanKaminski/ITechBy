using Domain.Common.Enums;
using ITechBy.Domain.Common;

namespace Infrastructure.Implementations.Entities.Account
{
    public class ConnectionEntity : AuditableEntity
    {
        public UserConnectionType Type { get; set; }

        public int UserFromId { get; set; }
        public UserEntity UserFrom { get; set; }

        public int UserToId { get; set; }
        public UserEntity UserTo { get; set; }
    }
}
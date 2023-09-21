using Domain.Common.Enums;
using ITechBy.Domain.Common;

namespace Services.Abstractions.Data.Entities.Communication
{
    public class UserConversationRoleEntity : AuditableEntity
    {
        public UserConversationRoleType Type { get; set; }

        public ICollection<UserConversationEntity> UserConversations { get; set; }
    }
}

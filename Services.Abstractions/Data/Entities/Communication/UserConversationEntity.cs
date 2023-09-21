using ITechBy.Domain.Common;
using Services.Abstractions.Data.Account;

namespace Services.Abstractions.Data.Entities.Communication
{
    public class UserConversationEntity : AuditableEntity
    {
        public int ConversationRoleId { get; set; }
        public UserConversationRoleEntity ConversationRole { get; set; }

        public int ConversationId { get; set; }
        public ConversationEntity Conversation { get; set; }

        public int UserId { get; set; }
        public UserEntity User { get; set; }
    }
}

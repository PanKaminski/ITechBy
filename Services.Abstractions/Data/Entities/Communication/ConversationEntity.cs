using ITechBy.Domain.Common;

namespace Services.Abstractions.Data.Entities.Communication
{
    public class ConversationEntity : AuditableEntity
    {
        public string Title { get; set; }
        public byte[] Avatar { get; set; }

        public ICollection<MessageEntity> Messages;

        public ICollection<UserConversationEntity> UserConversations { get; set; }
    }
}

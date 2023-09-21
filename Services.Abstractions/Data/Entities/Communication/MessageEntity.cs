using ITechBy.Domain.Common;
using Services.Abstractions.Data.Account;

namespace Services.Abstractions.Data.Entities.Communication
{
    public class MessageEntity : ManagedEntity
    {
        public string Text { get; set; }
        public ICollection<MediaAttachmentEntity> Attachments { get; set; }

        public int ConversationId { get; set; }
        public ConversationEntity Conversation { get; set; }

        public int SenderId { get; set; }
        public UserEntity Sender { get; set; }
    }
}

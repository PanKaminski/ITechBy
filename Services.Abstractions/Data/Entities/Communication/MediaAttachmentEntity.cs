using ITechBy.Domain.Common;

namespace Services.Abstractions.Data.Entities.Communication
{
    public class MediaAttachmentEntity : ManagedEntity
    {
        public string Url { get; set; }

        public int? MessageId { get; set; }
        public MessageEntity Message { get; set; }
    }
}

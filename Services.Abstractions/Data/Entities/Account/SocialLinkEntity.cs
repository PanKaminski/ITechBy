using Domain.Common.Enums;
using ITechBy.Domain.Common;

namespace Services.Abstractions.Data.Account
{
    public class SocialLinkEntity : AuditableEntity
    {
        public SocialLinkType SocialType { get; set; }
        public string Link { get; set; }
        public int UserId { get; set; }
        public UserEntity User { get; set; }
    }
}
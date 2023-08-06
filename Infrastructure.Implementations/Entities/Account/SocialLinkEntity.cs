using Domain.Common.Enums;
using ITechBy.Domain.Common;

namespace Infrastructure.Implementations.Entities.Account
{
    public class SocialLinkEntity
    {
        public SocialLinkType SocialType { get; set; }
        public string Link { get; set; }
        public int UserId { get; set; }
        public UserEntity User { get; set; }
    }
}
using Domain.Common.Enums;

namespace Services.Abstractions.Data.Account
{
    public class SocialLinkEntity
    {
        public SocialLinkType SocialType { get; set; }
        public string Link { get; set; }
        public int UserId { get; set; }
        public UserEntity User { get; set; }
    }
}
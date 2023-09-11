using ITechBy.Domain.Common;

namespace Domain.Models.Account
{
    public class RefreshToken : AuditableEntity
    {
        public RefreshToken(string source, DateTime expireTime)
        {
            Source = source;
            ExpireTime = expireTime;
            CreatedTime = DateTime.UtcNow;
        }

        public string Source { get; set; }
        public DateTime ExpireTime { get; set; }
    }
}

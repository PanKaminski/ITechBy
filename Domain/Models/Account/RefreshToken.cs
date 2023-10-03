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

        public RefreshToken(int id, string source, DateTime expireTime, DateTime createdTime)
        {
            Id = id;
            Source = source;
            ExpireTime = expireTime;
            CreatedTime = createdTime;
        }

        public string Source { get; set; }
        public DateTime ExpireTime { get; set; }
    }
}

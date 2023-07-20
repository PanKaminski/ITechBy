namespace ITechBy.Domain.Common
{
    public class ManagedEntity : AuditableEntity
    {
        public int? ChangedByAccount { get; set; }
    }
}

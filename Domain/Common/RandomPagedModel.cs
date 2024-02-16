using ITechBy.Domain.Common;

namespace Domain.Common
{
    public class RandomPagedModel<T> : PagedModel<T>
    {
        public ICollection<int> AttendedPages { get; set; }
    }
}

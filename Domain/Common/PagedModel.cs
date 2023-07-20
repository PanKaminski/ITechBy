namespace ITechBy.Domain.Common
{
    public class PagedModel<T>
    {
        private const int MaxPageSize = 50;
        private int pageSize;

        public int PageSize
        {
            get => pageSize;
            set => pageSize = value > MaxPageSize ? MaxPageSize : value;
        }

        public int CurrentPage { get; set; }

        public int TotalCount { get; set; }

        public int TotalPages => (int)Math.Ceiling(TotalCount / (double)PageSize);

        public IEnumerable<T> Items { get; set; }
    }
}

using ITechBy.Domain.Common;

namespace Services.Abstractions.Data.Repositories
{
    public interface IRepository<T>
    {
        IAsyncEnumerable<T> GetAllAsync();
        IAsyncEnumerable<T> GetAsync(Predicate<T> condition, int skipCount, int count, bool trackEntities);
        IAsyncEnumerable<T> GetAsync(Predicate<T> condition, bool trackEntities);
        Task<PagedModel<T>> GetPaginatedAsync(Predicate<T> condition, int page, int pageSize, bool trackEntities);
        IQueryable<T> Get(Predicate<T> condition, bool trackEntities);
        IQueryable<T> Get(Predicate<T> condition, int skipCount, int count, bool trackEntities);
        PagedModel<T> GetPaginated(Predicate<T> condition, int page, int pageSize, bool trackEntities);
        void Create(T entity);
        void Update(T entity);
        void Delete(int id);
    }
}

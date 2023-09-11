using ITechBy.Domain.Common;

namespace Services.Abstractions.Data.Repositories
{
    public interface IRepository<T>
    {
        IQueryable<T> GetAll(bool trackEntities);
        IAsyncEnumerable<T> GetAllAsync();
        Task<IEnumerable<T>> GetAllInChunkAsync(bool trackEntities);
        IAsyncEnumerable<T> GetAsync(Predicate<T> condition, int skipCount, int count, bool trackEntities);
        IAsyncEnumerable<T> GetAsync(Predicate<T> condition, bool trackEntities);
        Task<PagedModel<T>> GetPaginatedAsync(Predicate<T> condition, int page, int pageSize, bool trackEntities);
        IQueryable<T> Get(Predicate<T> condition, bool trackEntities);
        IQueryable<T> Get(Predicate<T> condition, int skipCount, int count, bool trackEntities);
        Task<T> FirstOrDefaultAsync(bool trackEntity);
        Task<T> FirstOrDefaultAsync(Predicate<T> condition, bool trackEntity);
        T FirstOrDefault(Predicate<T> condition, bool trackEntity);
        void Create(T entity);
        void Update(T entity);
        void Delete(int id);
    }
}

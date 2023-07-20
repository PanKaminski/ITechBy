namespace Infrastructure.Abstractions.Repositories
{
    public interface IRepository<T>
    {
        IAsyncEnumerable<T> GetAllAsync();
        IAsyncEnumerable<T> GetAsync(Predicate<T> condition, bool trackEntities);
        IAsyncEnumerable<T> GetPaginatedAsync(Predicate<T> condition, int page, int pageSize, bool trackEntities);
        IQueryable<T> Get(Predicate<T> condition, bool trackEntities);
        IQueryable<T> GetPaginated(Predicate<T> condition, int page, int pageSize, bool trackEntities);
        void Create(T entity);
        void Update(T entity);
        void Delete(int id);
    }
}

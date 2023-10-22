using ITechBy.Domain.Common;
using System.Linq.Expressions;

namespace Services.Abstractions.Data.Repositories
{
    public interface IRepository<T>
    {
        IQueryable<T> GetAll(bool trackEntities);
        IAsyncEnumerable<T> GetAllAsync();
        Task<IEnumerable<T>> GetAllInChunkAsync(bool trackEntities);
        IAsyncEnumerable<T> GetAsync(Expression<Func<T, bool>> condition, int skipCount, int count, bool trackEntities);
        IAsyncEnumerable<T> GetAsync(Expression<Func<T, bool>> condition, bool trackEntities);
        Task<PagedModel<T>> GetPaginatedAsync(Expression<Func<T, bool>> condition, int page, int pageSize, bool trackEntities);
        IQueryable<T> Get(Expression<Func<T, bool>> condition, bool trackEntities);
        IQueryable<T> Get(Expression<Func<T, bool>> condition, int skipCount, int count, bool trackEntities);
        Task<T> FirstOrDefaultAsync(bool trackEntity);
        Task<T> FirstOrDefaultAsync(Expression<Func<T, bool>> condition, bool trackEntity);
        T FirstOrDefault(Expression<Func<T, bool>> condition, bool trackEntity);
        void Create(T entity);
        void Update(T entity);
        void Delete(int id);
    }
}

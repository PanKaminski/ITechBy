using Domain.Exceptions;
using Infrastructure.Implementations.DataMaster;
using Infrastructure.Implementations.Extensions;
using ITechBy.Domain.Common;
using Microsoft.EntityFrameworkCore;
using Services.Abstractions.Data.Repositories;

namespace Infrastructure.Implementations.Repositories
{
    public abstract class RepositoryBase<T> : IRepository<T> where T : AuditableEntity
    {
        protected ITechDbContext DbContext { get; }

        public RepositoryBase(ITechDbContext context) => DbContext = context ?? throw new ArgumentNullException(nameof(context));

        public void Create(T entity)
        {
            ArgumentNullException.ThrowIfNull(entity, nameof(entity));

            entity.CreatedTime = DateTime.UtcNow;

            DbContext.Set<T>().Add(entity);
        }

        public void Delete(int id)
        {
            var entity = DbContext.Set<T>().Find(id);

            if (entity is null)
            {
                throw new ITechInfrastructureException(ExceptionCode.ItemDoesntExist);
            }

            DbContext.Set<T>().Remove(entity);
        }

        public IQueryable<T> Get(Predicate<T> condition, bool trackEntities)
        {
            IQueryable<T> model = DbContext.Set<T>().Where(item => condition(item));

            if (!trackEntities)
            {
                model = model.AsNoTracking();
            }

            return model;
        }

        public IQueryable<T> Get(Predicate<T> condition, int skipCount, int count, bool trackEntities)
        {
            if (skipCount < 0)
            {
                throw new ArgumentException("Count of items to skip is less than zero.");
            }

            if (count < 0)
            {
                throw new ArgumentException("Count of items to take is less than zero.");
            }

            return Get(condition, trackEntities).Skip(skipCount).Take(count);
        }

        public IAsyncEnumerable<T> GetAllAsync() => DbContext.Set<T>().AsNoTracking().AsAsyncEnumerable();

        public IAsyncEnumerable<T> GetAsync(Predicate<T> condition, int skipCount, int count, bool trackEntities) =>
            Get(condition, skipCount, count, trackEntities).AsAsyncEnumerable();

        public IAsyncEnumerable<T> GetAsync(Predicate<T> condition, bool trackEntities) =>
            Get(condition, trackEntities).AsAsyncEnumerable();


        public async Task<PagedModel<T>> GetPaginatedAsync(Predicate<T> condition, int page, int pageSize, bool trackEntities)
        {
            return await (Get(condition, trackEntities)).PaginateAsync(page, pageSize);
        }

        public void Update(T entity)
        {
            entity.UpdatedTime = DateTime.UtcNow;

            DbContext.Set<T>().Update(entity);
        }

        public IQueryable<T> GetAll(bool trackEntities) => !trackEntities ? DbContext.Set<T>().AsNoTracking() : DbContext.Set<T>();

        public async Task<T> FirstOrDefaultAsync(bool trackEntity)
        {
            IQueryable<T> model = DbContext.Set<T>();

            if (!trackEntity) model = model.AsNoTracking();

            return await model.FirstOrDefaultAsync();
        }

        public async Task<T> FirstOrDefaultAsync(Predicate<T> condition, bool trackEntity)
        {
            IQueryable<T> model = DbContext.Set<T>();

            if (!trackEntity) model = model.AsNoTracking();

            return await model.FirstOrDefaultAsync(item => condition(item));
        }

        public async Task<IEnumerable<T>> GetAllInChunkAsync(bool trackEntities)
        {
            var tokens = trackEntities ? DbContext.Set<T>() : DbContext.Set<T>().AsNoTracking();

            return await tokens.ToListAsync();
        }

        public T FirstOrDefault(Predicate<T> condition, bool trackEntity)
        {
            IQueryable<T> model = DbContext.Set<T>();

            if (!trackEntity) model = model.AsNoTracking();

            return model.FirstOrDefault(item => condition(item));
        }
    }
}

using Domain.Common;
using Domain.Extensions;
using ITechBy.Domain.Common;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Implementations.Extensions
{
    internal static class Pager
    {
        public static async Task<PagedModel<T>> PaginateAsync<T>(
                this IQueryable<T> queryCollection,
                int page,
                int limit,
                CancellationToken cancellationToken = default)
        {
            page = page <= 0 ? 1 : page;
            var start = (page - 1) * limit;

            var items = queryCollection.Skip(start).Take(limit).AsEnumerable();

            var count = await queryCollection.CountAsync(cancellationToken);
            return new PagedModel<T>
            {
                PageSize = limit,
                CurrentPage = page,
                TotalCount = count,
                Items = items
            };
        }

        public static async Task<RandomPagedModel<T>> RandomPaginateAsync<T>(
        this IQueryable<T> queryCollection,
        ICollection<int> attendedPages,
        int limit,
        CancellationToken cancellationToken = default)
        {
            var count = await queryCollection.CountAsync(cancellationToken);
            var maxPage = count / limit;
            int page = 1;

            while (attendedPages.Contains(page))
                page = Random.Shared.Next(1, maxPage);

            var start = (page - 1) * limit;

            var items = await queryCollection.Skip(start).Take(limit).ToArrayAsync();
            items.Shuffle();

            var lastAttendedPages = attendedPages.ToList();
            lastAttendedPages.Add(page);

            return new RandomPagedModel<T>
            {
                PageSize = limit,
                CurrentPage = page,
                TotalCount = count,
                AttendedPages = lastAttendedPages,
                Items = items
            };
        }
    }
}

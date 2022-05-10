using System.Linq.Expressions;
using Core.Entities;
using Microsoft.EntityFrameworkCore.Query;

namespace Core.DataAccess;

public interface IAsyncRepository<T> where T : BaseEntity
{
    Task<T> GetAsync(Expression<Func<T, bool>> predicate);

    Task<IList<T>> GetListAsync(Expression<Func<T, bool>> predicate = null,
        Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
        Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null, int index = 0, int size = 10,
        bool enableTracking = true,
        CancellationToken cancellationToken = default);

    IQueryable<T> Query();
    Task<T> AddAsync(T entity);
    Task UpdateAsync(T entity);
    Task DeleteAsync(T entity);
}
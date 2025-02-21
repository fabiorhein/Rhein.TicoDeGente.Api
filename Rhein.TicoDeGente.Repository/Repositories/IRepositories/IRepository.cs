using Microsoft.EntityFrameworkCore.Query;
using Rhein.TicoDeGente.Domain.Entities.Base;
using System.Linq.Expressions;

namespace Rhein.TicoDeGente.Repository.Repositories.IRepositories;

public interface IRepository<T> : IAsyncDisposable where T : EntityBase
{
    Task<T> GetByIdAsync(Guid id, Func<IQueryable<T>, IIncludableQueryable<T, object>> includeFunc = null);
    Task<IEnumerable<T>> GetAllAsync();
    Task<IEnumerable<T>> GetPaginatedAsync(int page, int pageSize);
    Task<IQueryable<T>> FindAsync(Expression<Func<T, bool>> predicate, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, Func<IQueryable<T>, IIncludableQueryable<T, object>> includeFunc = null);
    Task<int> CountAsync(Expression<Func<T, bool>> predicate = null);
    Task<T> InsertAsync(T entity);
    Task<T> UpdateAsync(T entity);
    Task DeleteAsync(T entity);
    Task DeleteByIdAsync(Guid id);
    Task DeleteRangeAsync(IEnumerable<T> entities);
}

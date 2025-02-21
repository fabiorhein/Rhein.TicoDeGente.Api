using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Rhein.TicoDeGente.Domain.Entities.Base;
using Rhein.TicoDeGente.Repository.Repositories.IRepositories;
using System.Data;
using System.Linq.Expressions;

namespace Rhein.TicoDeGente.Repository.Repositories.Base;

public class BaseRepository<T> : IRepository<T> where T : EntityBase
{
    protected IUnitOfWork Uow { get; set; }

    public BaseRepository(IUnitOfWork uow)
    {
        Uow = uow;
    }

    public virtual async Task<T> GetByIdAsync(Guid id, Func<IQueryable<T>, IIncludableQueryable<T, object>> includeFunc = null)
    {
        IQueryable<T> query = Uow.GetContext().Set<T>().AsNoTracking();
        if (includeFunc != null)
        {
            query = includeFunc(query);
        }
        return await query.FirstOrDefaultAsync(o => o.Id == id);
    }

    public virtual async Task<IEnumerable<T>> GetAllAsync()
    {
        return await Uow.GetContext().Set<T>().AsNoTracking().ToListAsync();
    }


    public virtual async Task<IEnumerable<T>> GetPaginatedAsync(int page, int pageSize)
    {
        return await Uow.GetContext().Set<T>().AsNoTracking().Skip((page - 1) * pageSize).Take(pageSize).ToListAsync();
    }

    public virtual async Task<IQueryable<T>> FindAsync(
        Expression<Func<T, bool>> predicate, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
        Func<IQueryable<T>, IIncludableQueryable<T, object>> includeFunc = null)
    {
        IQueryable<T> query = Uow.GetContext().Set<T>().AsNoTracking().Where(predicate);

        if (includeFunc != null)
        {
            query = includeFunc(query);
        }

        if (orderBy != null)
        {
            query = orderBy(query);
        }

        return query;
    }

    public virtual async Task<int> CountAsync(Expression<Func<T, bool>> predicate = null)
    {
        return predicate == null 
            ? await Uow.GetContext().Set<T>().CountAsync() 
            : await Uow.GetContext().Set<T>().CountAsync(predicate);
    }

    public virtual async Task<T> InsertAsync(T entity)
    {
        await Uow.GetContext().Set<T>().AddAsync(entity);
        await Uow.SaveChangesAsync();
        return entity;
    }

    public virtual async Task<T> UpdateAsync(T entity)
    {
        Uow.GetContext().Set<T>().Update(entity); 
        await Uow.SaveChangesAsync();
        return entity;
    }

    public virtual async Task DeleteAsync(T entity)
    {
        Uow.GetContext().Set<T>().Remove(entity);
        await Uow.SaveChangesAsync(); 
    }

    public virtual async Task DeleteByIdAsync(Guid id)
    {
        var entity = await Uow.GetContext().Set<T>().FindAsync(id); 
        if (entity != null)
        {
            Uow.GetContext().Set<T>().Remove(entity);
            await Uow.SaveChangesAsync();
        }
    }

    public virtual async Task DeleteRangeAsync(IEnumerable<T> entities)
    {
        Uow.GetContext().Set<T>().RemoveRange(entities);
        await Uow.SaveChangesAsync();
    }

    public async ValueTask DisposeAsync()
    {
        if (Uow != null)
        {
            await Uow.DisposeAsync();
            Uow = null;
        }

        GC.SuppressFinalize(this);
    }
}

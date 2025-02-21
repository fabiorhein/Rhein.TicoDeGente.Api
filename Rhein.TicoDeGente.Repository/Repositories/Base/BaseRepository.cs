using Microsoft.EntityFrameworkCore;
using Rhein.TicoDeGente.Domain.Entities.Base;
using Rhein.TicoDeGente.Repository.Repositories.IRepositories;
using System.Data;

namespace Rhein.TicoDeGente.Repository.Repositories.Base;

public class BaseRepository<T> : IRepository<T> where T : EntityBase
{
    protected IUnitOfWork Uow { get; set; }

    public BaseRepository(IUnitOfWork uow)
    {
        Uow = uow;
    }

    public virtual void Delete(T entity)
    {
       Uow.Context.Set<T>().Remove(entity);
       Uow.Context.SaveChanges();
    }

    public virtual async void DeleteAsync(T entity)
    {
        Uow.Context.Set<T>().Remove(entity);
        await Uow.Context.SaveChangesAsync();
    }

    public virtual void DeleteById(Guid id)
    {
        var obj = Activator.CreateInstance<T>();
        obj.Id = id;
        Uow.Context.Set<T>().Remove(obj);
        Uow.Context.SaveChanges();
    }

    public virtual void DeleteRange(IEnumerable<T> entities)
    {
       Uow.Context.Set<T>().RemoveRange(entities);
       Uow.Context.SaveChanges();
    }

    public virtual IEnumerable<T> GetAll()
    {
        return Uow.Context.Set<T>().ToList();
    }

    public virtual T GetById(Guid id)
    {
        return Uow.Context.Set<T>().FirstOrDefault(o => o.Id == id);
    }

    public virtual async Task<T> GetByIdAsync(Guid id)
    {
        return await Uow.Context.Set<T>().FirstOrDefaultAsync(o => o.Id == id);
    }

    public virtual T Save(T entity)
    {
        Uow.Context.Set<T>().Add(entity);
        Uow.Context.SaveChanges();
        return entity;
    }

    public virtual async Task<T> SaveAsync(T entity)
    {
        Uow.Context.Set<T>().Add(entity);
        await Uow.Context.SaveChangesAsync();
        return entity;
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

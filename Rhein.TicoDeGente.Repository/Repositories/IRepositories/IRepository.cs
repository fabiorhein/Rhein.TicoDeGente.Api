using Rhein.TicoDeGente.Domain.Entities.Base;

namespace Rhein.TicoDeGente.Repository.Repositories.IRepositories;

public interface IRepository<T> where T : EntityBase
{
    T GetById(Guid id);
    Task<T> GetByIdAsync(Guid id);
    IEnumerable<T> GetAll();

    T Save(T entity);
    Task<T> SaveAsync(T entity);

    void DeleteById(Guid id);
    void Delete(T entity);
    void DeleteRange(IEnumerable<T> entities);
    void DeleteAsync(T entity);
}

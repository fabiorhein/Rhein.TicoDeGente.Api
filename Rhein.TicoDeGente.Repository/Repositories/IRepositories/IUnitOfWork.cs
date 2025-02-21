using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System.Data;

namespace Rhein.TicoDeGente.Repository.Repositories.IRepositories;

public interface IUnitOfWork : IAsyncDisposable
{
    Guid Id { get; }
    IDbContextTransaction Transaction { get; }
    DbContext Context { get; set; }
    bool ValidateEntity { get; set; }

    Task BeginTransactionAsync();
    Task CommitAsync();
    Task RollbackAsync();
    Task<int> SaveChangesAsync();
}

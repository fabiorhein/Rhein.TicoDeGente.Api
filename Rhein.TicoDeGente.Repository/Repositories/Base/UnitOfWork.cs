using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Rhein.TicoDeGente.Repository.Repositories.IRepositories;

namespace Rhein.TicoDeGente.Repository.Repositories.Base;

public class UnitOfWork : IUnitOfWork
{
    public Guid Id => throw new NotImplementedException();

    public IDbContextTransaction Transaction => throw new NotImplementedException();

    public DbContext Context { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public bool ValidateEntity { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public Task BeginTransactionAsync()
    {
        throw new NotImplementedException();
    }

    public Task CommitAsync()
    {
        throw new NotImplementedException();
    }

    public ValueTask DisposeAsync()
    {
        throw new NotImplementedException();
    }

    public Task RollbackAsync()
    {
        throw new NotImplementedException();
    }

    public Task<int> SaveChangesAsync()
    {
        throw new NotImplementedException();
    }
}

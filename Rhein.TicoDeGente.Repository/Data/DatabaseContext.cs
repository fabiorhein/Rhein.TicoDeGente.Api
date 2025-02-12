using Microsoft.EntityFrameworkCore;

namespace Rhein.TicoDeGente.Repository.Data;

public class DatabaseContext : DbContext
{
    public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
    {
    }
}

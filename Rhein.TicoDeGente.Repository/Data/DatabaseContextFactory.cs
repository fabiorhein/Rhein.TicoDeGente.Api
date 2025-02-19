using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Rhein.TicoDeGente.Repository.Data;

public class DatabaseContextFactory : IDesignTimeDbContextFactory<DatabaseContext>
{
    public DatabaseContext CreateDbContext(string[] args)
    {
        var configuration = new ConfigurationBuilder()
                 .SetBasePath(Directory.GetCurrentDirectory())
                 .AddJsonFile("appsettings.json", true, true).Build();

        var optionsBuilder = new DbContextOptionsBuilder<DatabaseContext>();

        optionsBuilder.UseSqlite(configuration.GetConnectionString("DefaultConnection"));

        var context = new DatabaseContext(optionsBuilder.Options);

        return context;
    }
}

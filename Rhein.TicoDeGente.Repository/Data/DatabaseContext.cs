using Microsoft.EntityFrameworkCore;
using Rhein.TicoDeGente.Repository.Mappings;

namespace Rhein.TicoDeGente.Repository.Data;

public class DatabaseContext : DbContext
{

    public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new CategoryMapping());
        modelBuilder.ApplyConfiguration(new ColorMapping());
        modelBuilder.ApplyConfiguration(new CustomerMapping());
        modelBuilder.ApplyConfiguration(new InvoiceItemMapping());
        modelBuilder.ApplyConfiguration(new InvoiceMapping());
        modelBuilder.ApplyConfiguration(new OrderItemMapping());
        modelBuilder.ApplyConfiguration(new OrderMapping());
        modelBuilder.ApplyConfiguration(new PaymentMapping());
        modelBuilder.ApplyConfiguration(new PaymentMethodMapping());
        modelBuilder.ApplyConfiguration(new PermissionMapping());
        modelBuilder.ApplyConfiguration(new PriceMapping());
        modelBuilder.ApplyConfiguration(new PriceTableMapping());
        modelBuilder.ApplyConfiguration(new ProductMapping());
        modelBuilder.ApplyConfiguration(new RoleMapping());
        modelBuilder.ApplyConfiguration(new RolePermissionMapping());
        modelBuilder.ApplyConfiguration(new ShipmentItemMapping());
        modelBuilder.ApplyConfiguration(new ShipmentMapping());
        modelBuilder.ApplyConfiguration(new SizeMapping());
        modelBuilder.ApplyConfiguration(new UserMapping());
        modelBuilder.ApplyConfiguration(new UserRoleMapping());

        base.OnModelCreating(modelBuilder);
    }
}

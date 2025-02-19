using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rhein.TicoDeGente.Domain.Entities.Customers;
using Rhein.TicoDeGente.Repository.Utils;

namespace Rhein.TicoDeGente.Repository.Mappings;

public class CustomerMapping : IEntityTypeConfiguration<Customer>
{
    public void Configure(EntityTypeBuilder<Customer> builder)
    {
        builder.HasKey(c => c.Id);

        //builder.Property(c => c.Id)
        //    .HasConversion<UlidToStringConverter>()
        //    .HasConversion<UlidToBytesConverter>();


        builder.HasMany(c => c.Orders)
            .WithOne(o => o.Customer)
            .HasForeignKey(o => o.CustomerId);

        builder.HasMany(c => c.Invoices)
            .WithOne(i => i.Customer)
            .HasForeignKey(i => i.CustomerId);

        builder.HasMany(c => c.Payments)
            .WithOne(p => p.Customer)
            .HasForeignKey(p => p.CustomerId);

        builder.OwnsOne(c => c.Address);
    }
}

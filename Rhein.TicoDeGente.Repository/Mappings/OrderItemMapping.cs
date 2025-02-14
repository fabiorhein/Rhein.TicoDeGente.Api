using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rhein.TicoDeGente.Domain.Entities.Orders;

namespace Rhein.TicoDeGente.Repository.Mappings;

public class OrderItemMapping : IEntityTypeConfiguration<OrderItem>
{
    public void Configure(EntityTypeBuilder<OrderItem> builder)
    {
        builder.HasKey(oi => oi.Id);

        builder.HasOne(oi => oi.Product)
            .WithMany() 
            .HasForeignKey(oi => oi.ProductId);

        builder.HasOne(oi => oi.Order)
            .WithMany(o => o.Items)
            .HasForeignKey(oi => oi.OrderId);

        builder.OwnsOne(oi => oi.Discount); 
    }
}

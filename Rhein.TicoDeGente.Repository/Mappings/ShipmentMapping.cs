using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rhein.TicoDeGente.Domain.Entities.Invoices;

namespace Rhein.TicoDeGente.Repository.Mappings;

public class ShipmentMapping : IEntityTypeConfiguration<Shipment>
{
    public void Configure(EntityTypeBuilder<Shipment> builder)
    {
        builder.HasKey(s => s.Id);

        builder.HasOne(s => s.Order)
            .WithOne()
            .HasForeignKey<Shipment>(s => s.OrderId);

        builder.HasMany(s => s.Items)
            .WithOne(si => si.Shipment)
            .HasForeignKey(si => si.ShipmentId);
    }
}

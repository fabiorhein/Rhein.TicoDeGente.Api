using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Rhein.TicoDeGente.Domain.Entities.Invoices;

namespace Rhein.TicoDeGente.Repository.Mappings;

class ShipmentItemMapping : IEntityTypeConfiguration<ShipmentItem>
{
    public void Configure(EntityTypeBuilder<ShipmentItem> builder)
    {
        builder.HasKey(si => si.Id);

        builder.HasOne(si => si.Product)
            .WithMany()
            .HasForeignKey(si => si.ProductId);

        builder.HasOne(si => si.Shipment)
            .WithMany(s => s.Items)
            .HasForeignKey(si => si.ShipmentId);
    }
}

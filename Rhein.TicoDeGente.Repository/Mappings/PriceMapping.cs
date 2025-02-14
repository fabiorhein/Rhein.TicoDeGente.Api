using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Rhein.TicoDeGente.Domain.Entities.Pricing;

namespace Rhein.TicoDeGente.Repository.Mappings;

class PriceMapping : IEntityTypeConfiguration<Price>
{
    public void Configure(EntityTypeBuilder<Price> builder)
    {
        builder.HasKey(p => p.Id);

        builder.HasOne(p => p.Product)
            .WithMany()
            .HasForeignKey(p => p.ProductId);

        builder.HasOne(p => p.PriceTable)
            .WithMany(pt => pt.Prices)
            .HasForeignKey(p => p.PriceTableId);
    }
}

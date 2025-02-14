using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Rhein.TicoDeGente.Domain.Entities.Pricing;

namespace Rhein.TicoDeGente.Repository.Mappings;

class PriceTableMapping : IEntityTypeConfiguration<PriceTable>
{
    public void Configure(EntityTypeBuilder<PriceTable> builder)
    {
        builder.HasKey(pt => pt.Id);

        builder.HasMany(pt => pt.Prices)
            .WithOne(p => p.PriceTable)
            .HasForeignKey(p => p.PriceTableId);
    }
}

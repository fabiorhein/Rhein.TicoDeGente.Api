using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Rhein.TicoDeGente.Domain.Entities.Products;


namespace Rhein.TicoDeGente.Repository.Mappings;

public class SizeMapping : IEntityTypeConfiguration<Size>
{
    public void Configure(EntityTypeBuilder<Size> builder)
    {
        builder.HasKey(s => s.Id);

        builder.HasIndex(s => s.SizeDescription).IsUnique();
    }
}

using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Rhein.TicoDeGente.Domain.Entities.Products;

namespace Rhein.TicoDeGente.Repository.Mappings;

class ColorMapping : IEntityTypeConfiguration<Color>
{
    public void Configure(EntityTypeBuilder<Color> builder)
    {
        builder.HasKey(c => c.Id);
        builder.HasIndex(c => c.ColorName).IsUnique();
    }
}

public class SizeMapping : IEntityTypeConfiguration<Size>
{
    public void Configure(EntityTypeBuilder<Size> builder)
    {
        builder.HasKey(s => s.Id);
        builder.HasIndex(s => s.SizeDescription).IsUnique();
    }
}

public class CategoryMapping : IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder.HasKey(c => c.Id);
        builder.HasIndex(c => c.Name).IsUnique();
    }
}

using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Rhein.TicoDeGente.Domain.Entities.Products;

namespace Rhein.TicoDeGente.Repository.Mappings;

class ProductMapping : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.HasKey(p => p.Id);

        builder.HasOne(p => p.Category)
            .WithMany()
            .HasForeignKey(p => p.CategoryId);

        builder.HasOne(p => p.Size)
            .WithMany()
            .HasForeignKey(p => p.SizeId);

        builder.HasOne(p => p.Color)
            .WithMany()
            .HasForeignKey(p => p.ColorId);

        builder.HasOne(p => p.Stock)    
            .WithOne(s => s.Product)
            .HasForeignKey<Stock>(s => s.ProductId); 
    }
}

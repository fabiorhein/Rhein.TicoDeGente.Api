using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Rhein.TicoDeGente.Domain.Entities.Products;
using Rhein.TicoDeGente.Repository.Utils;

namespace Rhein.TicoDeGente.Repository.Mappings;

public class ProductMapping : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.HasKey(p => p.Id);

        //builder.Property(c => c.Id)
        //    .HasConversion<UlidToStringConverter>()
        //    .HasConversion<UlidToBytesConverter>();

        //builder.Property(c => c.CategoryId)
        //    .HasConversion<UlidToStringConverter>()
        //    .HasConversion<UlidToBytesConverter>();

        //builder.Property(c => c.SizeId)
        //    .HasConversion<UlidToStringConverter>()
        //    .HasConversion<UlidToBytesConverter>();

        //builder.Property(c => c.ColorId)
        //    .HasConversion<UlidToStringConverter>()
        //    .HasConversion<UlidToBytesConverter>();

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

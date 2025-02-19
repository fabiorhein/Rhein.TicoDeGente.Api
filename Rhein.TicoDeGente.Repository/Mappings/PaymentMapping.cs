using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rhein.TicoDeGente.Domain.Entities.Payments;
using Rhein.TicoDeGente.Repository.Utils;

namespace Rhein.TicoDeGente.Repository.Mappings;

public class PaymentMapping : IEntityTypeConfiguration<Payment>
{
    public void Configure(EntityTypeBuilder<Payment> builder)
    {
        builder.HasKey(p => p.Id);

        //builder.Property(c => c.Id)
        //    .HasConversion<UlidToStringConverter>()
        //    .HasConversion<UlidToBytesConverter>();

        //builder.Property(c => c.OrderId)
        //    .HasConversion<UlidToStringConverter>()
        //    .HasConversion<UlidToBytesConverter>();

        //builder.Property(c => c.InvoiceId)
        //    .HasConversion(
        //        ulid => ulid != null && ulid != Ulid.Empty ? ulid.ToString() : null, // Ulid? para string? (CORRIGIDO)
        //        str => !string.IsNullOrEmpty(str) ? Ulid.Parse(str) : null // string? para Ulid? (CORRIGIDO)
        //    );

        //builder.Property(c => c.CustomerId)
        //    .HasConversion<UlidToStringConverter>()
        //    .HasConversion<UlidToBytesConverter>();

        //builder.Property(c => c.PaymentMethodId)
        //    .HasConversion<UlidToStringConverter>()
        //    .HasConversion<UlidToBytesConverter>();

        builder.HasOne(p => p.Order)
            .WithMany()
            .HasForeignKey(p => p.OrderId);

        builder.HasOne(p => p.Invoice)
            .WithMany()
            .HasForeignKey(p => p.InvoiceId);

        builder.HasOne(p => p.Customer)
            .WithMany(c => c.Payments)
            .HasForeignKey(p => p.CustomerId);

        builder.HasOne(p => p.PaymentMethod)
            .WithMany()
            .HasForeignKey(p => p.PaymentMethodId);
    }
}

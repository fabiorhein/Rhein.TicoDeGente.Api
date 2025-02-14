using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rhein.TicoDeGente.Domain.Entities.Payments;

namespace Rhein.TicoDeGente.Repository.Mappings;

class PaymentMapping
{
    public void Configure(EntityTypeBuilder<Payment> builder)
    {
        builder.HasKey(p => p.Id);

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

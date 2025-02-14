using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Rhein.TicoDeGente.Domain.Entities.Payments;

namespace Rhein.TicoDeGente.Repository.Mappings;

class PaymentMethodMapping : IEntityTypeConfiguration<PaymentMethod>
{
    public void Configure(EntityTypeBuilder<PaymentMethod> builder)
    {
        builder.HasKey(pm => pm.Id);

        builder.Property(pm => pm.Type)
            .HasConversion(
                v => v.ToString(),
                v => (PaymentMethod.PaymentType)Enum.Parse(typeof(PaymentMethod.PaymentType), v)); 
    }
}

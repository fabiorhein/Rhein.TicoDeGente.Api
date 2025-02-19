using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Rhein.TicoDeGente.Domain.Entities.Payments;
using Rhein.TicoDeGente.Repository.Utils;

namespace Rhein.TicoDeGente.Repository.Mappings;

public class PaymentMethodMapping : IEntityTypeConfiguration<PaymentMethod>
{
    public void Configure(EntityTypeBuilder<PaymentMethod> builder)
    {
        builder.HasKey(pm => pm.Id);

        //builder.Property(c => c.Id)
        //    .HasConversion<UlidToStringConverter>()
        //    .HasConversion<UlidToBytesConverter>();

        builder.Property(pm => pm.Type)
            .HasConversion(
                v => v.ToString(),
                v => (PaymentMethod.PaymentType)Enum.Parse(typeof(PaymentMethod.PaymentType), v)); 
    }
}

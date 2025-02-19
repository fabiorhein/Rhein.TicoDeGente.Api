using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Rhein.TicoDeGente.Domain.Entities.Identities;
using Rhein.TicoDeGente.Repository.Utils;

namespace Rhein.TicoDeGente.Repository.Mappings;

class UserMapping : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.HasKey(u => u.Id);

        //builder.Property(c => c.Id)
        //    .HasConversion<UlidToStringConverter>()
        //    .HasConversion<UlidToBytesConverter>();

        builder.HasMany(u => u.UserRoles)
            .WithOne(ur => ur.User)
            .HasForeignKey(ur => ur.UserId);
    }
}

using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Rhein.TicoDeGente.Domain.Entities.Identities;
using Rhein.TicoDeGente.Repository.Utils;


namespace Rhein.TicoDeGente.Repository.Mappings;

class UserRoleMapping : IEntityTypeConfiguration<UserRole>
{
    public void Configure(EntityTypeBuilder<UserRole> builder)
    {
        builder.HasKey(ur => new { ur.UserId, ur.RoleId });

        //builder.Property(c => c.UserId)
        //    .HasConversion<UlidToStringConverter>()
        //    .HasConversion<UlidToBytesConverter>();

        //builder.Property(c => c.RoleId)
        //    .HasConversion<UlidToStringConverter>()
        //    .HasConversion<UlidToBytesConverter>();

        builder.HasOne(ur => ur.User)
            .WithMany(u => u.UserRoles)
            .HasForeignKey(ur => ur.UserId);

        builder.HasOne(ur => ur.Role)
            .WithMany() 
            .HasForeignKey(ur => ur.RoleId);
    }
}

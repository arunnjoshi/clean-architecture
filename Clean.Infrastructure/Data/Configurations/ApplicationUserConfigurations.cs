using Clean.Application.User;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Clean.Infrastructure.Data.Configurations;

public class ApplicationUserConfigurations : IEntityTypeConfiguration<ApplicationUser>
{
    public void Configure(EntityTypeBuilder<ApplicationUser> builder)
    {
        builder.Property(x => x.FirstName)
                .HasMaxLength(200)
                .IsRequired();

        builder.Property(x => x.LastName)
                .HasMaxLength(200)
                .IsRequired();

        builder.Property(x => x.MeddleName)
                .HasMaxLength(200);

        builder.Property(x => x.RefreshTokenExpiryTIme)
                .HasDefaultValue(null);
    }
}

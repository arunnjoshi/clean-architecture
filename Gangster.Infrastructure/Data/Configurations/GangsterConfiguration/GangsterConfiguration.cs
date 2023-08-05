using Gangster.ApiModel.Gangster;
using Microsoft.EntityFrameworkCore;

namespace Gangster.Infrastructure.Data.Configurations.GangsterConfiguration
{
    internal class GangsterConfiguration : IEntityTypeConfiguration<GangsterModel>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<GangsterModel> builder)
        {
            builder.Property(t => t.FirstName)
            .HasMaxLength(3)
            .HasMaxLength(200)
            .IsRequired();

            builder.Property(t => t.LastName)
                .HasMaxLength(200);

            builder.Property(t => t.DOB)
                .IsRequired();
        }
    }
}

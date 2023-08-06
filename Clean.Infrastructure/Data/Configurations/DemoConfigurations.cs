using Clean.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Clean.Infrastructure.Data.Configurations
{
    public class DemoConfigurations : IEntityTypeConfiguration<DemoEntity>
    {
        public void Configure(EntityTypeBuilder<DemoEntity> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(t => t.Id)
            .HasMaxLength(200)
            .IsRequired();

            builder.Property(t => t.DOB)
                .IsRequired();

            builder.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);
        }
    }
}

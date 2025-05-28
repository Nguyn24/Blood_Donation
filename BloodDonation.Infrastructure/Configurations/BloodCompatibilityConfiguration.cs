using BloodDonation.Domain.Bloods;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BloodDonation.Infrastructure.Configurations;

public class BloodCompatibilityConfiguration : IEntityTypeConfiguration<BloodCompatibility>
{
    public void Configure(EntityTypeBuilder<BloodCompatibility> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(x => x.FromBloodType)
            .IsRequired()
            .HasMaxLength(10);

        builder.Property(x => x.ToBloodType)
            .IsRequired()
            .HasMaxLength(10);

        builder.Property(x => x.ComponentType)
            .HasConversion<string>()
            .IsRequired();
    }
}
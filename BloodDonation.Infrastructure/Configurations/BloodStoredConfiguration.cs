using BloodDonation.Domain.Bloods;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BloodDonation.Infrastructure.Configurations;

public class BloodStoredConfiguration : IEntityTypeConfiguration<BloodStored>
{
    public void Configure(EntityTypeBuilder<BloodStored> builder)
    {
        builder.HasKey(x => x.StoredId);

        builder.Property(x => x.Quantity)
            .IsRequired();

        builder.Property(x => x.LastUpdated)
            .IsRequired();
        
        builder.HasOne<BloodType>()
            .WithMany()
            .HasForeignKey(x => x.BloodTypeId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
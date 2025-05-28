namespace BloodDonation.Domain.Bloods;

public class BloodCompatibility
{
    public Guid Id { get; set; }
    public string FromBloodType { get; set; }
    public string ToBloodType { get; set; }
    public BloodComponentType ComponentType { get; set; }
}
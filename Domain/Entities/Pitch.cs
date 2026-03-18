namespace HalisahaBackend.Domain.Entities;

public class Pitch
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public bool IsActive { get; set; } = true;
    public string Address { get; set; } = string.Empty;
    public string ContactPhoneNumber { get; set; } = string.Empty;
    public decimal HourlyPrice { get; set; }
    public int DistrictId { get; set; }
    public District District { get; set; } = null!;
    public int OwnerId { get; set; }
    public User Owner { get; set; } = null!;
    public ICollection<PitchFeature> PitchFeatures { get; set; } = new List<PitchFeature>();
}

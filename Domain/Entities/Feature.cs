namespace HalisahaBackend.Domain.Entities;

public class Feature
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public ICollection<PitchFeature> PitchFeatures { get; set; } = new List<PitchFeature>();
}

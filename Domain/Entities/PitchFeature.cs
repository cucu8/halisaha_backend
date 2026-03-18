namespace HalisahaBackend.Domain.Entities;

public class PitchFeature
{
    public int PitchId { get; set; }
    public Pitch Pitch { get; set; } = null!;
    public int FeatureId { get; set; }
    public Feature Feature { get; set; } = null!;
}

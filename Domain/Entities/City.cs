namespace HalisahaBackend.Domain.Entities;

public class City
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public virtual ICollection<District> Districts { get; set; } = new List<District>();
}

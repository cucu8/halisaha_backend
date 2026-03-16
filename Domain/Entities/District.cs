namespace HalisahaBackend.Domain.Entities;

public class District
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public int CityId { get; set; }
    public City City { get; set; } = null!;
    public virtual ICollection<Astroturf> Astroturfs { get; set; } = new List<Astroturf>();
}

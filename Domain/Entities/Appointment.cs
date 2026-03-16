namespace HalisahaBackend.Domain.Entities;

public class Appointment
{
    public int Id { get; set; }
    public int AstroturfId { get; set; }
    public Astroturf Astroturf { get; set; } = null!;
    public DateTime Date { get; set; }
    public string CustomerName { get; set; } = string.Empty;
    public string CustomerPhoneNumber { get; set; } = string.Empty;
}

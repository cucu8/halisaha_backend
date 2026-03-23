namespace HalisahaBackend.Domain.Entities;

public class Appointment
{
    public int Id { get; set; }
    public int PitchId { get; set; }
    public Pitch Pitch { get; set; } = null!;
    public DateTime Date { get; set; }
    public string CustomerName { get; set; } = string.Empty;
    public string CustomerPhoneNumber { get; set; } = string.Empty;
    public bool IsSubscription { get; set; } = false;
    public Guid? SubscriptionGroupId { get; set; }
}

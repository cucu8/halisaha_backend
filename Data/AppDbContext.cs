using Microsoft.EntityFrameworkCore;
using HalisahaBackend.Domain.Entities;
using HalisahaBackend.Domain.Enums;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace HalisahaBackend.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<User> Users { get; set; } = null!;
    public DbSet<City> Cities { get; set; } = null!;
    public DbSet<District> Districts { get; set; } = null!;
    public DbSet<Pitch> Pitches { get; set; } = null!;
    public DbSet<Feature> Features { get; set; } = null!;
    public DbSet<PitchFeature> PitchFeatures { get; set; } = null!;
    public DbSet<Appointment> Appointments { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Seed Admin User
        modelBuilder.Entity<User>().HasData(new User
        {
            Id = 1,
            Name = "Admin",
            PhoneNumber = "05334281441",
            PasswordHash = BCrypt.Net.BCrypt.HashPassword("111111"),
            Role = UserRole.Admin,
            IsActive = true
        });

        // Seed Cities from JSON
        var citiesPath = Path.Combine(Directory.GetCurrentDirectory(), "DataSeed", "sehirler.json");
        if (File.Exists(citiesPath))
        {
            var citiesJson = File.ReadAllText(citiesPath);
            var citySeeds = JsonSerializer.Deserialize<List<CityJson>>(citiesJson);
            if (citySeeds != null)
            {
                var cities = citySeeds.Select(c => new City { Id = c.Id, Name = c.Name }).ToList();
                modelBuilder.Entity<City>().HasData(cities);
            }
        }

        // Seed Districts from JSON
        var districtsPath = Path.Combine(Directory.GetCurrentDirectory(), "DataSeed", "ilceler.json");
        if (File.Exists(districtsPath))
        {
            var districtsJson = File.ReadAllText(districtsPath);
            var districtSeeds = JsonSerializer.Deserialize<List<DistrictJson>>(districtsJson);
            if (districtSeeds != null)
            {
                var districts = districtSeeds.Select(d => new District
                {
                    Id = d.Id,
                    Name = d.Name,
                    CityId = d.CityId
                }).ToList();
                modelBuilder.Entity<District>().HasData(districts);
            }
        }

        modelBuilder.Entity<Feature>().HasData(GetFeatureSeeds());

        modelBuilder.Entity<PitchFeature>()
            .HasKey(pf => new { pf.PitchId, pf.FeatureId });

        modelBuilder.Entity<PitchFeature>()
            .HasOne(pf => pf.Pitch)
            .WithMany(p => p.PitchFeatures)
            .HasForeignKey(pf => pf.PitchId);

        modelBuilder.Entity<PitchFeature>()
            .HasOne(pf => pf.Feature)
            .WithMany(f => f.PitchFeatures)
            .HasForeignKey(pf => pf.FeatureId);
    }

    private static List<Feature> GetFeatureSeeds()
    {
        return new List<Feature>
        {
            new Feature { Id = 1, Name = "Otopark" },
            new Feature { Id = 2, Name = "Kafe / Büfe" },
            new Feature { Id = 3, Name = "Duş" },
            new Feature { Id = 4, Name = "Aydınlatma" },
            new Feature { Id = 5, Name = "Klima (Kapalı Saha)" },
            new Feature { Id = 6, Name = "Çocuk Oyun Alanı" },
            new Feature { Id = 7, Name = "Maç Kaydı" },
            new Feature { Id = 8, Name = "Kiralık Kaleci" },
            new Feature { Id = 9, Name = "Kiralık Krampon" },
            new Feature { Id = 10, Name = "Kiralık Oyuncu" }
        };
    }

    private class CityJson
    {
        [JsonPropertyName("sehir_id")]
        [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
        public int Id { get; set; }

        [JsonPropertyName("sehir_adi")]
        public string Name { get; set; } = string.Empty;
    }

    private class DistrictJson
    {
        [JsonPropertyName("ilce_id")]
        [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
        public int Id { get; set; }

        [JsonPropertyName("ilce_adi")]
        public string Name { get; set; } = string.Empty;

        [JsonPropertyName("sehir_id")]
        [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
        public int CityId { get; set; }
    }
}

using Microsoft.EntityFrameworkCore;
using HalisahaBackend.Domain.Entities;
using HalisahaBackend.Domain.Enums;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace HalisahaBackend.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<User> Users { get; set; }
    public DbSet<City> Cities { get; set; }
    public DbSet<District> Districts { get; set; }
    public DbSet<Astroturf> Astroturfs { get; set; }
    public DbSet<Appointment> Appointments { get; set; }

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

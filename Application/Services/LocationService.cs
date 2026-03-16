using HalisahaBackend.Application.DTOs;
using HalisahaBackend.Application.Interfaces;
using HalisahaBackend.Data;
using Microsoft.EntityFrameworkCore;

namespace HalisahaBackend.Application.Services;

public class LocationService : ILocationService
{
    private readonly AppDbContext _context;

    public LocationService(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<CityDto>> GetCitiesAsync()
    {
        return await _context.Cities
            .Select(c => new CityDto(c.Id, c.Name))
            .ToListAsync();
    }

    public async Task<IEnumerable<DistrictDto>> GetDistrictsAsync(int cityId)
    {
        return await _context.Districts
            .Where(d => d.CityId == cityId)
            .Select(d => new DistrictDto(d.Id, d.Name))
            .ToListAsync();
    }
}

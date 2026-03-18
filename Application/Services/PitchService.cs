using HalisahaBackend.Application.DTOs;
using HalisahaBackend.Application.Interfaces;
using HalisahaBackend.Data;
using HalisahaBackend.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace HalisahaBackend.Application.Services;

public class PitchService : IPitchService
{
    private readonly AppDbContext _context;

    public PitchService(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<PitchResponseDto>> GetAllAsync(int? districtId = null)
    {
        var query = _context.Pitches
            .Include(a => a.District)
            .ThenInclude(d => d.City)
            .Include(a => a.Owner)
            .Include(a => a.PitchFeatures)
            .ThenInclude(pf => pf.Feature)
            .AsQueryable();

        if (districtId.HasValue)
            query = query.Where(a => a.DistrictId == districtId.Value);

        return await query.Select(p => new PitchResponseDto(
            p.Id,
            p.Name,
            p.Address,
            p.District.City.Name,
            p.District.Name,
            p.Owner.PhoneNumber,
            p.ContactPhoneNumber,
            p.HourlyPrice,
            p.PitchFeatures.Select(pf => pf.Feature.Name).ToList(),
            p.IsActive
        )).ToListAsync();
    }

    public async Task<IEnumerable<PitchResponseDto>> GetByOwnerAsync(int ownerId)
    {
        return await _context.Pitches
            .Include(a => a.District)
            .ThenInclude(d => d.City)
            .Include(a => a.Owner)
            .Include(a => a.PitchFeatures)
            .ThenInclude(pf => pf.Feature)
            .Where(a => a.OwnerId == ownerId)
            .Select(p => new PitchResponseDto(
                p.Id,
                p.Name,
                p.Address,
                p.District.City.Name,
                p.District.Name,
                p.Owner.PhoneNumber,
                p.ContactPhoneNumber,
                p.HourlyPrice,
                p.PitchFeatures.Select(pf => pf.Feature.Name).ToList(),
                p.IsActive
            )).ToListAsync();
    }

    public async Task<PitchResponseDto?> GetByIdAsync(int id)
    {
        var p = await _context.Pitches
            .Include(a => a.District)
            .ThenInclude(d => d.City)
            .Include(a => a.Owner)
            .Include(a => a.PitchFeatures)
            .ThenInclude(pf => pf.Feature)
            .FirstOrDefaultAsync(p => p.Id == id);

        if (p == null) return null;

        return new PitchResponseDto(
            p.Id,
            p.Name,
            p.Address,
            p.District.City.Name,
            p.District.Name,
            p.Owner.PhoneNumber,
            p.ContactPhoneNumber,
            p.HourlyPrice,
            p.PitchFeatures.Select(pf => pf.Feature.Name).ToList(),
            p.IsActive
        );
    }

    public async Task<bool> CreateAsync(int ownerId, CreatePitchRequest request)
    {
        var pitch = new Pitch
        {
            Name = request.Name,
            DistrictId = request.DistrictId,
            Address = request.Address ?? string.Empty,
            ContactPhoneNumber = request.ContactPhoneNumber ?? string.Empty,
            HourlyPrice = request.HourlyPrice,
            OwnerId = ownerId,
            IsActive = true
        };

        _context.Pitches.Add(pitch);
        await _context.SaveChangesAsync();

        var featureIds = request.FeatureIds ?? new List<int>();
        if (featureIds.Count > 0)
        {
            var validFeatureIds = await _context.Features
                .Where(f => featureIds.Contains(f.Id))
                .Select(f => f.Id)
                .ToListAsync();

            if (validFeatureIds.Count > 0)
            {
                var pitchFeatures = validFeatureIds.Select(featureId => new PitchFeature
                {
                    PitchId = pitch.Id,
                    FeatureId = featureId
                });
                _context.PitchFeatures.AddRange(pitchFeatures);
                await _context.SaveChangesAsync();
            }
        }
        return true;
    }

    public async Task<bool> UpdateAsync(int id, UpdatePitchRequest request)
    {
        var pitch = await _context.Pitches.FindAsync(id);
        if (pitch == null) return false;

        pitch.Name = request.Name;
        pitch.HourlyPrice = request.HourlyPrice;
        pitch.IsActive = request.IsActive;

        await _context.SaveChangesAsync();
        return true;
    }

    public async Task<bool> UpdateHourlyPriceAsync(int id, decimal hourlyPrice)
    {
        var pitch = await _context.Pitches.FindAsync(id);
        if (pitch == null) return false;

        pitch.HourlyPrice = hourlyPrice;
        await _context.SaveChangesAsync();
        return true;
    }

    public async Task<bool> DeleteAsync(int id)
    {
        var pitch = await _context.Pitches.FindAsync(id);
        if (pitch == null) return false;

        _context.Pitches.Remove(pitch);
        await _context.SaveChangesAsync();
        return true;
    }

    public async Task<bool> ToggleStatusAsync(int id)
    {
        var pitch = await _context.Pitches.FindAsync(id);
        if (pitch == null) return false;

        pitch.IsActive = !pitch.IsActive;
        await _context.SaveChangesAsync();
        return true;
    }
}

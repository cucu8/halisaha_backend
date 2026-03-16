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
            p.IsActive
        )).ToListAsync();
    }

    public async Task<IEnumerable<PitchResponseDto>> GetByOwnerAsync(int ownerId)
    {
        return await _context.Pitches
            .Include(a => a.District)
            .ThenInclude(d => d.City)
            .Include(a => a.Owner)
            .Where(a => a.OwnerId == ownerId)
            .Select(p => new PitchResponseDto(
                p.Id,
                p.Name,
                p.Address,
                p.District.City.Name,
                p.District.Name,
                p.Owner.PhoneNumber,
                p.IsActive
            )).ToListAsync();
    }

    public async Task<PitchResponseDto?> GetByIdAsync(int id)
    {
        var p = await _context.Pitches
            .Include(a => a.District)
            .ThenInclude(d => d.City)
            .Include(a => a.Owner)
            .FirstOrDefaultAsync(p => p.Id == id);

        if (p == null) return null;

        return new PitchResponseDto(
            p.Id,
            p.Name,
            p.Address,
            p.District.City.Name,
            p.District.Name,
            p.Owner.PhoneNumber,
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
            OwnerId = ownerId,
            IsActive = true
        };

        _context.Pitches.Add(pitch);
        await _context.SaveChangesAsync();
        return true;
    }

    public async Task<bool> UpdateAsync(int id, UpdatePitchRequest request)
    {
        var pitch = await _context.Pitches.FindAsync(id);
        if (pitch == null) return false;

        pitch.Name = request.Name;
        pitch.IsActive = request.IsActive;

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

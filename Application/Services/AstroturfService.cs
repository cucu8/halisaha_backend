using HalisahaBackend.Application.DTOs;
using HalisahaBackend.Application.Interfaces;
using HalisahaBackend.Data;
using HalisahaBackend.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace HalisahaBackend.Application.Services;

public class AstroturfService : IAstroturfService
{
    private readonly AppDbContext _context;

    public AstroturfService(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Astroturf>> GetAllAsync(int? districtId = null)
    {
        var query = _context.Astroturfs.AsQueryable();
        if (districtId.HasValue)
            query = query.Where(a => a.DistrictId == districtId.Value);

        return await query.ToListAsync();
    }

    public async Task<Astroturf?> GetByIdAsync(int id)
    {
        return await _context.Astroturfs.FindAsync(id);
    }

    public async Task<bool> UpdateAsync(int id, UpdateAstroturfRequest request)
    {
        var astroturf = await _context.Astroturfs.FindAsync(id);
        if (astroturf == null) return false;

        astroturf.Name = request.Name;
        astroturf.IsActive = request.IsActive;

        await _context.SaveChangesAsync();
        return true;
    }

    public async Task<bool> DeleteAsync(int id)
    {
        var astroturf = await _context.Astroturfs.FindAsync(id);
        if (astroturf == null) return false;

        _context.Astroturfs.Remove(astroturf);
        await _context.SaveChangesAsync();
        return true;
    }

    public async Task<bool> ToggleStatusAsync(int id)
    {
        var astroturf = await _context.Astroturfs.FindAsync(id);
        if (astroturf == null) return false;

        astroturf.IsActive = !astroturf.IsActive;
        await _context.SaveChangesAsync();
        return true;
    }
}

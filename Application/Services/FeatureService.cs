using HalisahaBackend.Application.DTOs;
using HalisahaBackend.Application.Interfaces;
using HalisahaBackend.Data;
using Microsoft.EntityFrameworkCore;

namespace HalisahaBackend.Application.Services;

public class FeatureService : IFeatureService
{
    private readonly AppDbContext _context;

    public FeatureService(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<FeatureDto>> GetAllAsync()
    {
        return await _context.Features
            .OrderBy(f => f.Id)
            .Select(f => new FeatureDto(f.Id, f.Name))
            .ToListAsync();
    }
}

using HalisahaBackend.Application.DTOs;
using HalisahaBackend.Application.Interfaces;
using HalisahaBackend.Data;
using HalisahaBackend.Domain.Entities;
using HalisahaBackend.Domain.Enums;
using Microsoft.EntityFrameworkCore;

namespace HalisahaBackend.Application.Services;

public class UserService : IUserService
{
    private readonly AppDbContext _context;

    public UserService(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<UserResponse>> GetAllOwnersAsync()
    {
        var owners = await _context.Users
            .Where(u => u.Role == UserRole.Owner)
            .ToListAsync();

        var ownerIds = owners.Select(o => o.Id).ToList();

        var pitches = await _context.Astroturfs
            .Include(a => a.District)
            .ThenInclude(d => d.City)
            .Where(a => ownerIds.Contains(a.OwnerId))
            .ToListAsync();

        return owners.Select(u =>
        {
            var pitch = pitches.FirstOrDefault(p => p.OwnerId == u.Id);
            return new UserResponse(
                u.Id,
                u.Name,
                u.PhoneNumber,
                u.Role,
                u.IsActive,
                pitch?.Name,
                pitch?.District?.City?.Name,
                pitch?.District?.Name
            );
        });
    }

    public async Task<bool> ToggleStatusAsync(int id)
    {
        var user = await _context.Users.FindAsync(id);
        if (user == null) return false;

        user.IsActive = !user.IsActive;

        // Also toggle associated astroturfs
        var pitches = await _context.Astroturfs.Where(a => a.OwnerId == id).ToListAsync();
        foreach (var pitch in pitches)
        {
            pitch.IsActive = user.IsActive;
        }

        await _context.SaveChangesAsync();
        return true;
    }

    public async Task<bool> DeleteAsync(int id)
    {
        var user = await _context.Users.FindAsync(id);
        if (user == null) return false;

        // Find associated astroturfs
        var pitches = await _context.Astroturfs.Where(a => a.OwnerId == id).ToListAsync();
        var pitchIds = pitches.Select(p => p.Id).ToList();

        // Find and remove associated appointments
        var appointments = await _context.Appointments.Where(app => pitchIds.Contains(app.AstroturfId)).ToListAsync();
        _context.Appointments.RemoveRange(appointments);

        // Remove astroturfs
        _context.Astroturfs.RemoveRange(pitches);

        // Remove user
        _context.Users.Remove(user);

        await _context.SaveChangesAsync();
        return true;
    }
}

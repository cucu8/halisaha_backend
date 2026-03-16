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
        return await GetUsersByRoleAsync(UserRole.Owner);
    }

    public async Task<IEnumerable<UserResponse>> GetAllUsersAsync()
    {
        return await GetUsersByRoleAsync(null);
    }

    private async Task<IEnumerable<UserResponse>> GetUsersByRoleAsync(UserRole? role)
    {
        var query = _context.Users.AsQueryable();
        if (role.HasValue)
        {
            query = query.Where(u => u.Role == role.Value);
        }

        var users = await query.ToListAsync();
        var userIds = users.Select(u => u.Id).ToList();

        var pitches = await _context.Pitches
            .Include(a => a.District)
            .ThenInclude(d => d.City)
            .Where(a => userIds.Contains(a.OwnerId))
            .ToListAsync();

        return users.Select(u =>
        {
            var userPitches = pitches.Where(p => p.OwnerId == u.Id)
                .Select(p => new OwnerPitchDto(
                    p.Id,
                    p.Name,
                    p.District?.City?.Name,
                    p.District?.Name,
                    p.Address,
                    p.IsActive
                )).ToList();

            return new UserResponse(
                u.Id,
                u.Name,
                u.PhoneNumber,
                u.Role,
                u.IsActive,
                userPitches
            );
        });
    }

    public async Task<bool> ToggleStatusAsync(int id)
    {
        var user = await _context.Users.FindAsync(id);
        if (user == null) return false;

        user.IsActive = !user.IsActive;

        // Also toggle associated pitches
        var pitches = await _context.Pitches.Where(a => a.OwnerId == id).ToListAsync();
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

        // Find associated pitches
        var pitches = await _context.Pitches.Where(a => a.OwnerId == id).ToListAsync();
        var pitchIds = pitches.Select(p => p.Id).ToList();

        // Find and remove associated appointments
        var appointments = await _context.Appointments.Where(app => pitchIds.Contains(app.PitchId)).ToListAsync();
        _context.Appointments.RemoveRange(appointments);

        // Remove pitches
        _context.Pitches.RemoveRange(pitches);

        // Remove user
        _context.Users.Remove(user);

        await _context.SaveChangesAsync();
        return true;
    }
}

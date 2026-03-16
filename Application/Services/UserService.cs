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

    public async Task<IEnumerable<User>> GetAllOwnersAsync()
    {
        return await _context.Users
            .Where(u => u.Role == UserRole.Owner)
            .ToListAsync();
    }

    public async Task<bool> ToggleStatusAsync(int id)
    {
        var user = await _context.Users.FindAsync(id);
        if (user == null) return false;

        user.IsActive = !user.IsActive;
        await _context.SaveChangesAsync();
        return true;
    }

    public async Task<bool> DeleteAsync(int id)
    {
        var user = await _context.Users.FindAsync(id);
        if (user == null) return false;

        // Hard delete
        _context.Users.Remove(user);
        await _context.SaveChangesAsync();
        return true;
    }
}

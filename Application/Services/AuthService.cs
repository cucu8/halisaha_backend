using HalisahaBackend.Application.DTOs;
using HalisahaBackend.Application.Interfaces;
using HalisahaBackend.Data;
using HalisahaBackend.Domain.Entities;
using HalisahaBackend.Domain.Enums;
using HalisahaBackend.Infrastructure.Security;
using Microsoft.EntityFrameworkCore;
using BCrypt.Net;

namespace HalisahaBackend.Application.Services;

public class AuthService : IAuthService
{
    private readonly AppDbContext _context;
    private readonly ITokenService _tokenService;

    public AuthService(AppDbContext context, ITokenService tokenService)
    {
        _context = context;
        _tokenService = tokenService;
    }

    public async Task<LoginResponse?> LoginAsync(LoginRequest request)
    {
        var user = await _context.Users.FirstOrDefaultAsync(u => u.PhoneNumber == request.PhoneNumber);
        if (user == null || !BCrypt.Net.BCrypt.Verify(request.Password, user.PasswordHash))
            return null;

        if (!user.IsActive)
            throw new Exception("Account is inactive.");

        int? pitchId = null;
        if (user.Role == UserRole.Owner)
        {
            var pitch = await _context.Pitches.FirstOrDefaultAsync(a => a.OwnerId == user.Id);
            pitchId = pitch?.Id;
        }

        var token = _tokenService.CreateToken(user);
        return new LoginResponse(token, user.Name, user.Role, pitchId);
    }

    public async Task<bool> CreateOwnerAsync(CreateOwnerRequest request)
    {
        if (await _context.Users.AnyAsync(u => u.PhoneNumber == request.PhoneNumber))
            return false;

        var owner = new User
        {
            Name = request.FullName,
            PhoneNumber = request.PhoneNumber,
            PasswordHash = BCrypt.Net.BCrypt.HashPassword(request.Password),
            Role = UserRole.Owner,
            IsActive = true
        };

        _context.Users.Add(owner);
        await _context.SaveChangesAsync();

        return true;
    }
}

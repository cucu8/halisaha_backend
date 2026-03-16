using HalisahaBackend.Domain.Enums;

namespace HalisahaBackend.Application.DTOs;

public record LoginRequest(string PhoneNumber, string Password);
public record LoginResponse(string Token, string Name, UserRole Role, int? PitchId);
public record UserResponse(int Id, string Name, string PhoneNumber, UserRole Role, bool IsActive, string? PitchName, string? City, string? District);

public record CityDto(int Id, string Name);
public record DistrictDto(int Id, string Name);

public record CreateOwnerRequest(string PhoneNumber, string Password, string Username, string PitchName, int DistrictId, string? Address);
public record UpdateAstroturfRequest(string Name, bool IsActive);
public record CreateAppointmentRequest(int AstroturfId, DateTime Date, string CustomerName, string CustomerPhoneNumber);
public record UpdateAppointmentRequest(string CustomerName, string CustomerPhoneNumber);

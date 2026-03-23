using HalisahaBackend.Domain.Enums;

namespace HalisahaBackend.Application.DTOs;

public record LoginRequest(string PhoneNumber, string Password);
public record LoginResponse(string Token, string Name, UserRole Role, int? PitchId);
public record OwnerPitchDto(int Id, string Name, string? City, string? District, string? Address, string ContactPhoneNumber, decimal HourlyPrice, List<string> Features, bool IsActive);
public record PitchResponseDto(int Id, string Name, string Address, int CityId, string City, int DistrictId, string District, string OwnerPhoneNumber, string ContactPhoneNumber, decimal HourlyPrice, List<string> Features, bool IsActive);
public record UserResponse(int Id, string Name, string PhoneNumber, UserRole Role, bool IsActive, List<OwnerPitchDto> Pitches);

public record CityDto(int Id, string Name);
public record DistrictDto(int Id, string Name);

public record CreateOwnerRequest(string PhoneNumber, string Password, string FullName);
public record CreatePitchRequest(string Name, int DistrictId, string? Address, string? ContactPhoneNumber, decimal HourlyPrice, List<int>? FeatureIds);
public record UpdatePitchRequest(string Name, int DistrictId, string? Address, string? ContactPhoneNumber, decimal HourlyPrice, List<int>? FeatureIds, bool IsActive);
public record UpdatePitchPriceRequest(decimal HourlyPrice);
public record CreateAppointmentRequest(int PitchId, DateTime Date, string CustomerName, string CustomerPhoneNumber, bool IsSubscription = false, int SubscriptionWeeks = 1, bool ForceCreate = false);
public record UpdateAppointmentRequest(string CustomerName, string CustomerPhoneNumber);

public record ConflictInfo(DateTime Date, string CustomerName, string CustomerPhoneNumber);
public record CreateAppointmentResponse(bool Success, int CreatedCount, List<ConflictInfo> Conflicts);

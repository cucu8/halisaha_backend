using HalisahaBackend.Domain.Entities;
using HalisahaBackend.Application.DTOs;

namespace HalisahaBackend.Application.Interfaces;

public interface IAuthService
{
    Task<LoginResponse?> LoginAsync(LoginRequest request);
    Task<bool> CreateOwnerAsync(CreateOwnerRequest request);
}

public interface IUserService
{
    Task<IEnumerable<UserResponse>> GetAllOwnersAsync();
    Task<IEnumerable<UserResponse>> GetAllUsersAsync();
    Task<bool> ToggleStatusAsync(int id);
    Task<bool> DeleteAsync(int id);
}

public interface ILocationService
{
    Task<IEnumerable<CityDto>> GetCitiesAsync();
    Task<IEnumerable<DistrictDto>> GetDistrictsAsync(int cityId);
}

public interface IFeatureService
{
    Task<IEnumerable<FeatureDto>> GetAllAsync();
}

public interface IPitchService
{
    Task<IEnumerable<PitchResponseDto>> GetAllAsync(int? districtId = null);
    Task<IEnumerable<PitchResponseDto>> GetByOwnerAsync(int ownerId);
    Task<PitchResponseDto?> GetByIdAsync(int id);
    Task<bool> CreateAsync(int ownerId, CreatePitchRequest request);
    Task<bool> UpdateAsync(int id, UpdatePitchRequest request);
    Task<bool> UpdateHourlyPriceAsync(int id, decimal hourlyPrice);
    Task<bool> DeleteAsync(int id);
    Task<bool> ToggleStatusAsync(int id);
}

public interface IAppointmentService
{
    Task<bool> CreateAppointmentAsync(CreateAppointmentRequest request);
    Task<IEnumerable<Appointment>> GetAppointmentsByPitchAsync(int pitchId, DateTime? startDate = null);
    Task<bool> UpdateAppointmentAsync(int id, UpdateAppointmentRequest request);
    Task<bool> CancelAppointmentAsync(int id);
}

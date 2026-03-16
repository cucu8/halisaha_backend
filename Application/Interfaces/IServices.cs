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
    Task<IEnumerable<User>> GetAllOwnersAsync();
    Task<bool> ToggleStatusAsync(int id);
    Task<bool> DeleteAsync(int id);
}

public interface ILocationService
{
    Task<IEnumerable<CityDto>> GetCitiesAsync();
    Task<IEnumerable<DistrictDto>> GetDistrictsAsync(int cityId);
}

public interface IAstroturfService
{
    Task<IEnumerable<Astroturf>> GetAllAsync(int? districtId = null);
    Task<Astroturf?> GetByIdAsync(int id);
    Task<bool> UpdateAsync(int id, UpdateAstroturfRequest request);
    Task<bool> DeleteAsync(int id);
    Task<bool> ToggleStatusAsync(int id);
}

public interface IAppointmentService
{
    Task<bool> CreateAppointmentAsync(CreateAppointmentRequest request);
    Task<object> GetAppointmentsByAstroturfAsync(int astroturfId);
    Task<bool> UpdateAppointmentAsync(int id, UpdateAppointmentRequest request);
    Task<bool> CancelAppointmentAsync(int id);
}

using HalisahaBackend.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace HalisahaBackend.Controllers;

[ApiController]
[Route("api/[controller]")]
public class LocationController : ControllerBase
{
    private readonly ILocationService _locationService;

    public LocationController(ILocationService locationService)
    {
        _locationService = locationService;
    }

    [HttpGet("cities")]
    public async Task<IActionResult> GetCities()
    {
        return Ok(await _locationService.GetCitiesAsync());
    }

    [HttpGet("cities/{cityId}/districts")]
    public async Task<IActionResult> GetDistricts(int cityId)
    {
        return Ok(await _locationService.GetDistrictsAsync(cityId));
    }
}

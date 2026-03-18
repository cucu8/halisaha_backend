using HalisahaBackend.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace HalisahaBackend.Controllers;

[ApiController]
[Route("api/[controller]")]
public class FeatureController : ControllerBase
{
    private readonly IFeatureService _featureService;

    public FeatureController(IFeatureService featureService)
    {
        _featureService = featureService;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        return Ok(await _featureService.GetAllAsync());
    }
}

using HalisahaBackend.Application.DTOs;
using HalisahaBackend.Application.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HalisahaBackend.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AstroturfController : ControllerBase
{
    private readonly IAstroturfService _astroturfService;

    public AstroturfController(IAstroturfService astroturfService)
    {
        _astroturfService = astroturfService;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll([FromQuery] int? districtId)
    {
        return Ok(await _astroturfService.GetAllAsync(districtId));
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var result = await _astroturfService.GetByIdAsync(id);
        return result == null ? NotFound() : Ok(result);
    }

    [Authorize(Roles = "Admin,Owner")]
    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, UpdateAstroturfRequest request)
    {
        var success = await _astroturfService.UpdateAsync(id, request);
        return success ? Ok("Astroturf updated successfully.") : NotFound();
    }

    [Authorize(Roles = "Admin")]
    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var success = await _astroturfService.DeleteAsync(id);
        return success ? Ok("Astroturf deleted successfully.") : NotFound();
    }

    [Authorize(Roles = "Admin,Owner")]
    [HttpPatch("{id}/toggle-status")]
    public async Task<IActionResult> ToggleStatus(int id)
    {
        var success = await _astroturfService.ToggleStatusAsync(id);
        return success ? Ok("Astroturf status toggled.") : NotFound();
    }
}

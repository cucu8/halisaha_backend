using HalisahaBackend.Application.DTOs;
using HalisahaBackend.Application.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HalisahaBackend.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PitchController : ControllerBase
{
    private readonly IPitchService _pitchService;

    public PitchController(IPitchService pitchService)
    {
        _pitchService = pitchService;
    }

    [Authorize(Roles = "Owner")]
    [HttpPost]
    public async Task<IActionResult> Create(CreatePitchRequest request)
    {
        var ownerId = int.Parse(User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value ?? "0");
        if (ownerId == 0) return Unauthorized();

        var success = await _pitchService.CreateAsync(ownerId, request);
        return success ? Ok("Pitch created successfully.") : BadRequest("Could not create pitch.");
    }

    [Authorize(Roles = "Owner")]
    [HttpGet("my-pitches")]
    public async Task<IActionResult> GetMyPitches()
    {
        var ownerId = int.Parse(User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value ?? "0");
        if (ownerId == 0) return Unauthorized();

        return Ok(await _pitchService.GetByOwnerAsync(ownerId));
    }

    [HttpGet]
    public async Task<IActionResult> GetAll([FromQuery] int? districtId)
    {
        return Ok(await _pitchService.GetAllAsync(districtId));
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var result = await _pitchService.GetByIdAsync(id);
        return result == null ? NotFound() : Ok(result);
    }

    [Authorize(Roles = "Admin,Owner")]
    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, UpdatePitchRequest request)
    {
        var success = await _pitchService.UpdateAsync(id, request);
        return success ? Ok("Pitch updated successfully.") : NotFound();
    }

    [Authorize(Roles = "Admin")]
    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var success = await _pitchService.DeleteAsync(id);
        return success ? Ok("Pitch deleted successfully.") : NotFound();
    }

    [Authorize(Roles = "Admin,Owner")]
    [HttpPatch("{id}/toggle-status")]
    public async Task<IActionResult> ToggleStatus(int id)
    {
        var success = await _pitchService.ToggleStatusAsync(id);
        return success ? Ok("Pitch status toggled.") : NotFound();
    }
}

using HalisahaBackend.Application.DTOs;
using HalisahaBackend.Application.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HalisahaBackend.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    private readonly IAuthService _authService;

    public AuthController(IAuthService authService)
    {
        _authService = authService;
    }

    [HttpPost("login")]
    public async Task<IActionResult> Login(LoginRequest request)
    {
        try
        {
            var response = await _authService.LoginAsync(request);
            if (response == null) return Unauthorized("Invalid phone number or password.");
            return Ok(response);
        }
        catch (Exception ex) when (ex.Message == "Account is inactive.")
        {
            return StatusCode(403, "Hesabınız pasif durumdadır. Lütfen yönetici ile iletişime geçin.");
        }
    }

    [Authorize(Roles = "Admin")]
    [HttpPost("create-owner")]
    public async Task<IActionResult> CreateOwner(CreateOwnerRequest request)
    {
        var success = await _authService.CreateOwnerAsync(request);
        if (!success) return BadRequest("Owner could not be created or already exists.");
        return Ok("Owner and astroturf created successfully.");
    }
}

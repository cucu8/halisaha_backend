using HalisahaBackend.Application.DTOs;
using HalisahaBackend.Application.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HalisahaBackend.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AppointmentController : ControllerBase
{
    private readonly IAppointmentService _appointmentService;

    public AppointmentController(IAppointmentService appointmentService)
    {
        _appointmentService = appointmentService;
    }

    [HttpPost("create")]
    public async Task<IActionResult> CreateAppointment(CreateAppointmentRequest request)
    {
        var success = await _appointmentService.CreateAppointmentAsync(request);
        if (!success) return BadRequest("Appointment slot is not available.");
        return Ok("Appointment created successfully.");
    }

    [HttpGet("{astroturfId}")]
    public async Task<IActionResult> GetAppointments(int astroturfId)
    {
        var appointments = await _appointmentService.GetAppointmentsByAstroturfAsync(astroturfId);
        return Ok(appointments);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateAppointment(int id, UpdateAppointmentRequest request)
    {
        var success = await _appointmentService.UpdateAppointmentAsync(id, request);
        return success ? Ok("Appointment updated successfully.") : NotFound();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> CancelAppointment(int id)
    {
        var success = await _appointmentService.CancelAppointmentAsync(id);
        return success ? Ok("Appointment cancelled successfully.") : NotFound();
    }
}

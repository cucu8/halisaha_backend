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
        var result = await _appointmentService.CreateAppointmentAsync(request);
        if (!result.Success)
            return Conflict(result); // 409 with conflict details
        return Ok(result);
    }

    [HttpGet("{pitchId}")]
    public async Task<IActionResult> GetAppointments(int pitchId, [FromQuery] DateTime? startDate)
    {
        var appointments = await _appointmentService.GetAppointmentsByPitchAsync(pitchId, startDate);
        return Ok(appointments);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateAppointment(int id, UpdateAppointmentRequest request)
    {
        var success = await _appointmentService.UpdateAppointmentAsync(id, request);
        return success ? Ok("Appointment updated successfully.") : NotFound();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> CancelAppointment(int id, [FromQuery] bool cancelAll = false)
    {
        var success = await _appointmentService.CancelAppointmentAsync(id, cancelAll);
        return success ? Ok("Appointment cancelled successfully.") : NotFound();
    }
}

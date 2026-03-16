using HalisahaBackend.Application.DTOs;
using HalisahaBackend.Application.Interfaces;
using HalisahaBackend.Data;
using HalisahaBackend.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace HalisahaBackend.Application.Services;

public class AppointmentService : IAppointmentService
{
    private readonly AppDbContext _context;

    public AppointmentService(AppDbContext context)
    {
        _context = context;
    }

    public async Task<bool> CreateAppointmentAsync(CreateAppointmentRequest request)
    {
        // Simple 1-hour slot check
        var startTime = request.Date;
        var endTime = startTime.AddHours(1);

        var exists = await _context.Appointments
            .AnyAsync(a => a.PitchId == request.PitchId &&
                           ((a.Date >= startTime && a.Date < endTime) ||
                            (a.Date.AddHours(1) > startTime && a.Date.AddHours(1) <= endTime)));

        if (exists) return false;

        var appointment = new Appointment
        {
            PitchId = request.PitchId,
            Date = request.Date,
            CustomerName = request.CustomerName,
            CustomerPhoneNumber = request.CustomerPhoneNumber
        };

        _context.Appointments.Add(appointment);
        await _context.SaveChangesAsync();
        return true;
    }

    public async Task<IEnumerable<Appointment>> GetAppointmentsByPitchAsync(int pitchId, DateTime? startDate = null)
    {
        var query = _context.Appointments.Where(a => a.PitchId == pitchId);

        if (startDate.HasValue)
        {
            var end = startDate.Value.AddDays(7);
            query = query.Where(a => a.Date >= startDate.Value && a.Date < end);
        }

        return await query
            .OrderBy(a => a.Date)
            .ToListAsync();
    }

    public async Task<bool> UpdateAppointmentAsync(int id, UpdateAppointmentRequest request)
    {
        var appointment = await _context.Appointments.FindAsync(id);
        if (appointment == null) return false;

        appointment.CustomerName = request.CustomerName;
        appointment.CustomerPhoneNumber = request.CustomerPhoneNumber;

        await _context.SaveChangesAsync();
        return true;
    }

    public async Task<bool> CancelAppointmentAsync(int id)
    {
        var appointment = await _context.Appointments.FindAsync(id);
        if (appointment == null) return false;

        _context.Appointments.Remove(appointment);
        await _context.SaveChangesAsync();
        return true;
    }
}

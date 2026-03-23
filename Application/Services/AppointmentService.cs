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

    public async Task<CreateAppointmentResponse> CreateAppointmentAsync(CreateAppointmentRequest request)
    {
        var weeks = request.IsSubscription ? Math.Clamp(request.SubscriptionWeeks, 1, 52) : 1;
        var groupId = request.IsSubscription ? Guid.NewGuid() : (Guid?)null;

        var conflicts = new List<ConflictInfo>();
        var slotsToCreate = new List<(DateTime slotDate, bool hasConflict)>();

        // Phase 1: Check all weeks for conflicts
        for (int w = 0; w < weeks; w++)
        {
            var slotDate = request.Date.AddDays(w * 7);
            var endTime = slotDate.AddHours(1);

            var conflicting = await _context.Appointments
                .Where(a => a.PitchId == request.PitchId &&
                           ((a.Date >= slotDate && a.Date < endTime) ||
                            (a.Date.AddHours(1) > slotDate && a.Date.AddHours(1) <= endTime)))
                .Select(a => new ConflictInfo(a.Date, a.CustomerName, a.CustomerPhoneNumber))
                .FirstOrDefaultAsync();

            if (conflicting != null)
            {
                conflicts.Add(conflicting);
                slotsToCreate.Add((slotDate, true));
            }
            else
            {
                slotsToCreate.Add((slotDate, false));
            }
        }

        // Phase 2: If there are conflicts and user hasn't confirmed, return the conflicts
        if (conflicts.Count > 0 && !request.ForceCreate)
        {
            return new CreateAppointmentResponse(false, 0, conflicts);
        }

        // Phase 3: Create only non-conflicting slots
        var createdCount = 0;
        foreach (var (slotDate, hasConflict) in slotsToCreate)
        {
            if (hasConflict) continue;

            var appointment = new Appointment
            {
                PitchId = request.PitchId,
                Date = slotDate,
                CustomerName = request.CustomerName,
                CustomerPhoneNumber = request.CustomerPhoneNumber,
                IsSubscription = request.IsSubscription,
                SubscriptionGroupId = groupId
            };

            _context.Appointments.Add(appointment);
            createdCount++;
        }

        if (createdCount > 0)
            await _context.SaveChangesAsync();

        return new CreateAppointmentResponse(true, createdCount, conflicts);
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

    public async Task<bool> CancelAppointmentAsync(int id, bool cancelAll = false)
    {
        var appointment = await _context.Appointments.FindAsync(id);
        if (appointment == null) return false;

        if (cancelAll && appointment.IsSubscription && appointment.SubscriptionGroupId.HasValue)
        {
            // Delete this appointment and all future appointments in the same subscription group
            var futureAppointments = await _context.Appointments
                .Where(a => a.SubscriptionGroupId == appointment.SubscriptionGroupId
                         && a.Date >= appointment.Date)
                .ToListAsync();

            _context.Appointments.RemoveRange(futureAppointments);
        }
        else
        {
            _context.Appointments.Remove(appointment);
        }

        await _context.SaveChangesAsync();
        return true;
    }
}

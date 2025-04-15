using Api.Doctor.EFCoreContext;
using Api.Doctor.Models;
using Api.Doctor.Repositories.Bases;
using Api.Doctor.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;



namespace Api.Doctor.Repositories.Implementations
{
    public class ScheduleRepository : BaseRepository<Schedule>, IScheduleRepository
    {
        public ScheduleRepository(DoctorCareDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Schedule>> GetSchedulesByDoctorAsync(int doctorId)
        {
            return await _context.Schedules
                                 .Where(s => s.DoctorId == doctorId)
                                 .ToListAsync();
        }
    }
}
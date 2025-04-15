using Api.Doctor.EFCoreContext;
using Api.Doctor.Models;
using Api.Doctor.Repositories.Bases;
using Api.Doctor.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;



namespace Api.Doctor.Repositories.Implementations
{
    public class SupporterLogRepository : BaseRepository<SupporterLog>, ISupporterLogRepository
    {
        public SupporterLogRepository(DoctorCareDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<SupporterLog>> GetByPatientIdAsync(int patientId)
        {
            return await _context.SupporterLogs
                                 .Where(s => s.PatientId == patientId)
                                 .ToListAsync();
        }
    }
}
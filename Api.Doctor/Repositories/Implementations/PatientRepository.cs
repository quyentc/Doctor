using Api.Doctor.EFCoreContext;
using Api.Doctor.Models;
using Api.Doctor.Repositories.Bases;
using Api.Doctor.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;



namespace Api.Doctor.Repositories.Implementations
{
    public class PatientRepository : BaseRepository<Patient>, IPatientRepository
    {
        public PatientRepository(DoctorCareDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Patient>> GetByDoctorIdAsync(int doctorId)
        {
            return await _context.Patients
                                 .Where(p => p.DoctorId == doctorId)
                                 .ToListAsync();
        }

        public async Task<IEnumerable<Patient>> GetByStatusIdAsync(int statusId)
        {
            return await _context.Patients
                                 .Where(p => p.StatusId == statusId)
                                 .ToListAsync();
        }
    }
}
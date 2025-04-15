using Api.Doctor.EFCoreContext;
using Api.Doctor.Models;
using Api.Doctor.Repositories.Bases;
using Api.Doctor.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;



namespace Api.Doctor.Repositories.Implementations
{
    public class DoctorUserRepository : BaseRepository<DoctorUser>, IDoctorUserRepository
    {
        public DoctorUserRepository(DoctorCareDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<DoctorUser>> GetByClinicIdAsync(int clinicId)
        {
            return await _context.DoctorUsers
                                 .Where(du => du.ClinicId == clinicId)
                                 .ToListAsync();
        }

        public async Task<IEnumerable<DoctorUser>> GetBySpecializationIdAsync(int specializationId)
        {
            return await _context.DoctorUsers
                                 .Where(du => du.SpecializationId == specializationId)
                                 .ToListAsync();
        }
    }
}
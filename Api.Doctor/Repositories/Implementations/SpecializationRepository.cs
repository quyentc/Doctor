using Api.Doctor.EFCoreContext;
using Api.Doctor.Models;
using Api.Doctor.Repositories.Bases;
using Api.Doctor.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;



namespace Api.Doctor.Repositories.Implementations
{
    public class SpecializationRepository : BaseRepository<Specialization>, ISpecializationRepository
    {
        public SpecializationRepository(DoctorCareDbContext context) : base(context)
        {
        }

        public async Task<Specialization?> GetByNameAsync(string name)
        {
            return await _context.Specializations
                                 .FirstOrDefaultAsync(s => s.Name == name);
        }
    }
}
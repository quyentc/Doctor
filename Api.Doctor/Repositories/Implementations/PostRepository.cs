using Api.Doctor.EFCoreContext;
using Api.Doctor.Models;
using Api.Doctor.Repositories.Bases;
using Api.Doctor.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;



namespace Api.Doctor.Repositories.Implementations
{
    public class PostRepository : BaseRepository<Post>, IPostRepository
    {
        public PostRepository(DoctorCareDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Post>> GetPostsByClinicAsync(int clinicId)
        {
            return await _context.Posts
                                 .Where(p => p.ForClinicId == clinicId)
                                 .ToListAsync();
        }

        public async Task<IEnumerable<Post>> GetPostsBySpecializationAsync(int specializationId)
        {
            return await _context.Posts
                                 .Where(p => p.ForSpecializationId == specializationId)
                                 .ToListAsync();
        }

        public async Task<IEnumerable<Post>> GetPostsByDoctorAsync(int doctorId)
        {
            return await _context.Posts
                                 .Where(p => p.ForDoctorId == doctorId)
                                 .ToListAsync();
        }
    }
}
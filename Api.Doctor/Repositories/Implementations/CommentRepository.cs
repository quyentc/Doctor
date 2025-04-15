using Api.Doctor.EFCoreContext;
using Api.Doctor.Models;
using Api.Doctor.Repositories.Bases;
using Api.Doctor.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;



namespace Api.Doctor.Repositories.Implementations
{
    public class CommentRepository : BaseRepository<Comment>, ICommentRepository
    {
        public CommentRepository(DoctorCareDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Comment>> GetCommentsByDoctorIdAsync(int doctorId)
        {
            return await _context.Comments
                                  .Where(c => c.DoctorId == doctorId)
                                  .ToListAsync();
        }
    }
}

using Api.Doctor.EFCoreContext;
using Api.Doctor.Models;
using Api.Doctor.Repositories.Interfaces;
using Api.Doctor.Services.Bases;
using Api.Doctor.Services.Interfaces;


namespace Api.Doctor.Services.Implementations
{
    public class CommentService : BaseService<Comment>, ICommentService
    {
        private readonly ICommentRepository _commentRepository;

        public CommentService(ICommentRepository repository)
            : base(repository)
        {
            _commentRepository = repository;
        }

        public async Task<IEnumerable<Comment>> GetCommentsByDoctorIdAsync(int doctorId)
        {
            return await _commentRepository.GetCommentsByDoctorIdAsync(doctorId);
        }
    }
}
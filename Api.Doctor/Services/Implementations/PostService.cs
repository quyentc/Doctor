using Api.Doctor.EFCoreContext;
using Api.Doctor.Models;
using Api.Doctor.Repositories.Interfaces;
using Api.Doctor.Services.Bases;
using Api.Doctor.Services.Interfaces;


namespace Api.Doctor.Services.Implementations
{
    public class PostService : BaseService<Post>, IPostService
    {
        private readonly IPostRepository _postRepository;

        public PostService(IPostRepository repository)
            : base(repository)
        {
            _postRepository = repository;
        }

        public async Task<IEnumerable<Post>> GetPostsByClinicAsync(int clinicId)
        {
            return await _postRepository.GetPostsByClinicAsync(clinicId);
        }

        public async Task<IEnumerable<Post>> GetPostsBySpecializationAsync(int specializationId)
        {
            return await _postRepository.GetPostsBySpecializationAsync(specializationId);
        }

        public async Task<IEnumerable<Post>> GetPostsByDoctorAsync(int doctorId)
        {
            return await _postRepository.GetPostsByDoctorAsync(doctorId);
        }
    }
}


using Api.Doctor.Models;
using Api.Doctor.Repositories.Bases;

namespace Api.Doctor.Repositories.Interfaces
{
    public interface IPostRepository : IBaseRepository<Post>
    {
        Task<IEnumerable<Post>> GetPostsByClinicAsync(int clinicId);
        Task<IEnumerable<Post>> GetPostsBySpecializationAsync(int specializationId);
        Task<IEnumerable<Post>> GetPostsByDoctorAsync(int doctorId);
    }
}

using Api.Doctor.Models;
using Api.Doctor.Services.Bases;

namespace Api.Doctor.Services.Interfaces
{
    public interface IPostService : IBaseService<Post>
    {
        Task<IEnumerable<Post>> GetPostsByClinicAsync(int clinicId);
        Task<IEnumerable<Post>> GetPostsBySpecializationAsync(int specializationId);
        Task<IEnumerable<Post>> GetPostsByDoctorAsync(int doctorId);
    }
}

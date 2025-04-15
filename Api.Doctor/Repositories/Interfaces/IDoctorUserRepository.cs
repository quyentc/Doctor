using Api.Doctor.Models;
using Api.Doctor.Repositories.Bases;

namespace Api.Doctor.Repositories.Interfaces
{
    public interface IDoctorUserRepository : IBaseRepository<DoctorUser>
    {
        Task<IEnumerable<DoctorUser>> GetByClinicIdAsync(int clinicId);
        Task<IEnumerable<DoctorUser>> GetBySpecializationIdAsync(int specializationId);
    }
}

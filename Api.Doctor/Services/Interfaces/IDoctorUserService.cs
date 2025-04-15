
using Api.Doctor.Models;
using Api.Doctor.Services.Bases;

namespace Api.Doctor.Services.Interfaces
{
    public interface IDoctorUserService : IBaseService<DoctorUser>
    {
        Task<IEnumerable<DoctorUser>> GetByClinicIdAsync(int clinicId);
        Task<IEnumerable<DoctorUser>> GetBySpecializationIdAsync(int specializationId);
    }
}

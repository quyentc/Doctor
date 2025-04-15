using Api.Doctor.Models;
using Api.Doctor.Services.Bases;

namespace Api.Doctor.Services.Interfaces
{
    public interface IPatientService : IBaseService<Patient>
    {
        Task<IEnumerable<Patient>> GetByDoctorIdAsync(int doctorId);
        Task<IEnumerable<Patient>> GetByStatusIdAsync(int statusId);
    }
}

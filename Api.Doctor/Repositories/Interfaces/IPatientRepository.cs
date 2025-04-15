
using Api.Doctor.Models;
using Api.Doctor.Repositories.Bases;

namespace Api.Doctor.Repositories.Interfaces
{
    public interface IPatientRepository : IBaseRepository<Patient>
    {
        Task<IEnumerable<Patient>> GetByDoctorIdAsync(int doctorId);
        Task<IEnumerable<Patient>> GetByStatusIdAsync(int statusId);
    }
}

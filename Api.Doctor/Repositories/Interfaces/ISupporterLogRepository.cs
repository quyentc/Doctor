using Api.Doctor.Models;
using Api.Doctor.Repositories.Bases;

namespace Api.Doctor.Repositories.Interfaces
{
    public interface ISupporterLogRepository : IBaseRepository<SupporterLog>
    {
        Task<IEnumerable<SupporterLog>> GetByPatientIdAsync(int patientId);
    }
}

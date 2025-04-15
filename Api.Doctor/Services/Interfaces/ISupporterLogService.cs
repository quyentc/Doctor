using Api.Doctor.Models;
using Api.Doctor.Services.Bases;

namespace Api.Doctor.Services.Interfaces
{
    public interface ISupporterLogService : IBaseService<SupporterLog>
    {
        Task<IEnumerable<SupporterLog>> GetByPatientIdAsync(int patientId);
    }
}

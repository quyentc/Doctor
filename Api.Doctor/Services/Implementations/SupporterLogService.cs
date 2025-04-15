using Api.Doctor.EFCoreContext;
using Api.Doctor.Models;
using Api.Doctor.Repositories.Interfaces;
using Api.Doctor.Services.Bases;
using Api.Doctor.Services.Interfaces;


namespace Api.Doctor.Services.Implementations
{
    public class SupporterLogService : BaseService<SupporterLog>, ISupporterLogService
    {
        private readonly ISupporterLogRepository _supporterLogRepository;

        public SupporterLogService(ISupporterLogRepository repository)
            : base(repository)
        {
            _supporterLogRepository = repository;
        }

        public async Task<IEnumerable<SupporterLog>> GetByPatientIdAsync(int patientId)
        {
            return await _supporterLogRepository.GetByPatientIdAsync(patientId);
        }
    }
}

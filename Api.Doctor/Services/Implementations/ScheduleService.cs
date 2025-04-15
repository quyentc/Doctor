using Api.Doctor.EFCoreContext;
using Api.Doctor.Models;
using Api.Doctor.Repositories.Interfaces;
using Api.Doctor.Services.Bases;
using Api.Doctor.Services.Interfaces;


namespace Api.Doctor.Services.Implementations
{
    public class ScheduleService : BaseService<Schedule>, IScheduleService
    {
        private readonly IScheduleRepository _scheduleRepository;

        public ScheduleService(IScheduleRepository repository)
            : base(repository)
        {
            _scheduleRepository = repository;
        }

        public async Task<IEnumerable<Schedule>> GetSchedulesByDoctorAsync(int doctorId)
        {
            return await _scheduleRepository.GetSchedulesByDoctorAsync(doctorId);
        }
    }
}

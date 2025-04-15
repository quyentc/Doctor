
using Api.Doctor.Models;
using Api.Doctor.Repositories.Bases;

namespace Api.Doctor.Repositories.Interfaces
{
    public interface IScheduleRepository : IBaseRepository<Schedule>
    {
        Task<IEnumerable<Schedule>> GetSchedulesByDoctorAsync(int doctorId);
    }
}

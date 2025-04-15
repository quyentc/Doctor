using Api.Doctor.Models;
using Api.Doctor.Services.Bases;

namespace Api.Doctor.Services.Interfaces
{
    public interface IScheduleService : IBaseService<Schedule>
    {
        Task<IEnumerable<Schedule>> GetSchedulesByDoctorAsync(int doctorId);
    }
}

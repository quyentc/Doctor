using Api.Doctor.Models;
using Api.Doctor.Services.Bases;

namespace Api.Doctor.Services.Interfaces
{
    public interface ICommentService : IBaseService<Comment>
    {
        Task<IEnumerable<Comment>> GetCommentsByDoctorIdAsync(int doctorId);
    }
}

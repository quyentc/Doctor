using Api.Doctor.Models;
using Api.Doctor.Services.Bases;

namespace Api.Doctor.Services.Interfaces
{
    public interface ISpecializationService : IBaseService<Specialization>
    {
        Task<Specialization?> GetByNameAsync(string name);
    }
}

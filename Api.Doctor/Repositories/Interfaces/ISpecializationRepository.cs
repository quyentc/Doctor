
using Api.Doctor.Models;
using Api.Doctor.Repositories.Bases;

namespace Api.Doctor.Repositories.Interfaces
{
    public interface ISpecializationRepository : IBaseRepository<Specialization>
    {
        Task<Specialization?> GetByNameAsync(string name);
    }
}

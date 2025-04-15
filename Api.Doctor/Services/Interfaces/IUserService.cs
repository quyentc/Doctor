using Api.Doctor.Models;
using Api.Doctor.Services.Bases;

namespace Api.Doctor.Services.Interfaces
{
    public interface IUserService : IBaseService<User>
    {
        Task AddAsync(User user);
        Task SaveAsync();
        Task<User?> GetByEmailAsync(string email);
    }
}

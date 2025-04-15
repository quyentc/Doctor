using Api.Doctor.EFCoreContext;
using Api.Doctor.Models;
using Api.Doctor.Repositories.Interfaces;
using Api.Doctor.Services.Bases;
using Api.Doctor.Services.Interfaces;


namespace Api.Doctor.Services.Implementations
{
    public class SpecializationService : BaseService<Specialization>, ISpecializationService
    {
        private readonly ISpecializationRepository _specializationRepository;

        public SpecializationService(ISpecializationRepository repository)
            : base(repository)
        {
            _specializationRepository = repository;
        }

        public async Task<Specialization?> GetByNameAsync(string name)
        {
            return await _specializationRepository.GetByNameAsync(name);
        }
    }
}
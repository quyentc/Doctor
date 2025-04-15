using Api.Doctor.EFCoreContext;
using Api.Doctor.Models;
using Api.Doctor.Repositories.Interfaces;
using Api.Doctor.Services.Bases;
using Api.Doctor.Services.Interfaces;


namespace Api.Doctor.Services.Implementations
{
    public class DoctorUserService : BaseService<DoctorUser>, IDoctorUserService
    {
        private readonly IDoctorUserRepository _doctorUserRepository;

        public DoctorUserService(IDoctorUserRepository repository)
            : base(repository)
        {
            _doctorUserRepository = repository;
        }

        public async Task<IEnumerable<DoctorUser>> GetByClinicIdAsync(int clinicId)
        {
            return await _doctorUserRepository.GetByClinicIdAsync(clinicId);
        }

        public async Task<IEnumerable<DoctorUser>> GetBySpecializationIdAsync(int specializationId)
        {
            return await _doctorUserRepository.GetBySpecializationIdAsync(specializationId);
        }
    }
}

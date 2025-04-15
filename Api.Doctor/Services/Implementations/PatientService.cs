
using Api.Doctor.EFCoreContext;
using Api.Doctor.Models;
using Api.Doctor.Repositories.Interfaces;
using Api.Doctor.Services.Bases;
using Api.Doctor.Services.Interfaces;


namespace Api.Doctor.Services.Implementations
{
    public class PatientService : BaseService<Patient>, IPatientService
    {
        private readonly IPatientRepository _patientRepository;

        public PatientService(IPatientRepository repository)
            : base(repository)
        {
            _patientRepository = repository;
        }

        public async Task<IEnumerable<Patient>> GetByDoctorIdAsync(int doctorId)
        {
            return await _patientRepository.GetByDoctorIdAsync(doctorId);
        }

        public async Task<IEnumerable<Patient>> GetByStatusIdAsync(int statusId)
        {
            return await _patientRepository.GetByStatusIdAsync(statusId);
        }
    }
}

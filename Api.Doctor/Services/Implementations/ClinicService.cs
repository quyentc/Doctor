using Api.Doctor.EFCoreContext;
using Api.Doctor.Models;
using Api.Doctor.Repositories.Interfaces;
using Api.Doctor.Services.Bases;
using Api.Doctor.Services.Interfaces;


namespace Api.Doctor.Services.Implementations
{
    public class ClinicService : BaseService<Clinic>, IClinicService
    {
        private readonly IClinicRepository _clinicRepository;
        private readonly DoctorCareDbContext _context;

        // Constructor nhận cả repository và DbContext
        public ClinicService(IClinicRepository repository, DoctorCareDbContext context)
            : base(repository)
        {
            _clinicRepository = repository;
            _context = context;
        }

        public async Task CreateAsync(Clinic clinic)
        {
            await _context.Clinics.AddAsync(clinic);
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}


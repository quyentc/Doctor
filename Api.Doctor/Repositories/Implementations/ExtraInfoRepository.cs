using Api.Doctor.EFCoreContext;
using Api.Doctor.Models;
using Api.Doctor.Repositories.Bases;
using Api.Doctor.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;



namespace Api.Doctor.Repositories.Implementations
{
    public class ExtraInfoRepository : BaseRepository<ExtraInfo>, IExtraInfoRepository
    {
        public ExtraInfoRepository(DoctorCareDbContext context) : base(context)
        {
        }
    }
}
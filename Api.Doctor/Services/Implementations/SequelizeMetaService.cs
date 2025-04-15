using Api.Doctor.EFCoreContext;
using Api.Doctor.Models;
using Api.Doctor.Repositories.Interfaces;
using Api.Doctor.Services.Bases;
using Api.Doctor.Services.Interfaces;


namespace Api.Doctor.Services.Implementations
{
    public class SequelizeMetaService : BaseService<SequelizeMeta>, ISequelizeMetaService
    {
        public SequelizeMetaService(ISequelizeMetaRepository repository)
            : base(repository)
        {
        }
    }
}


using Api.Doctor.EFCoreContext;
using Api.Doctor.Models;
using Api.Doctor.Repositories.Interfaces;
using Api.Doctor.Services.Bases;
using Api.Doctor.Services.Interfaces;


namespace Api.Doctor.Services.Implementations
{
    public class SessionService : BaseService<Session>, ISessionService
    {
        public SessionService(ISessionRepository repository)
            : base(repository)
        {
        }
    }
}


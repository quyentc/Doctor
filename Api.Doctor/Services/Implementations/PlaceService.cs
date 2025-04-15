using Api.Doctor.EFCoreContext;
using Api.Doctor.Models;
using Api.Doctor.Repositories.Interfaces;
using Api.Doctor.Services.Bases;
using Api.Doctor.Services.Interfaces;


namespace Api.Doctor.Services.Implementations
{
    public class PlaceService : BaseService<Place>, IPlaceService
    {
        public PlaceService(IPlaceRepository repository)
            : base(repository)
        {
        }
    }
}


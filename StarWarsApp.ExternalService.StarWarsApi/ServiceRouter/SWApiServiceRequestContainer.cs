using StarWarsApp.ExternalService.StarWarsApi.Services;

namespace StarWarsApp.ExternalService.StarWarsApi.ServiceRouter
{
    internal class SWApiServiceRequestContainer
    {
        public SWApiServiceRequestContainer(object serviceImplementation, params Type[] requests)
        {
            Implementation = serviceImplementation;
            Requests = requests;
        }

        public object Implementation { get; set; }

        public IEnumerable<Type> Requests { get; set; } = Enumerable.Empty<Type>();

        public static readonly SWApiServiceRequestContainer[] ImplementedServices = new SWApiServiceRequestContainer[]
        {
            new(new SWApiFilmService(), typeof(GetAllFilmsRequest), typeof(GetFilmsByTitleRequest), typeof(GetFilmByIdRequest)),
            new(new SWApiPeopleService(), typeof(GetAllPeopleRequest), typeof(GetPeopleByNameRequest), typeof(GetPersonByIdRequest)),
            new(new SWApiPlanetService(), typeof(GetAllPlanetsRequest), typeof(GetPlanetsByNameRequest), typeof(GetPlanetByIdRequest)),
            new(new SWApiSpeciesService(), typeof(GetAllSpeciesRequest), typeof(GetSpeciesByNameRequest), typeof(GetSpeciesByIdRequest)),
            new(new SWApiStarshipService(), typeof(GetAllStarshipsRequest), typeof(GetStarshipsByNameRequest), typeof(GetStarshipByIdRequest)),
            new(new SWApiVehicleService(), typeof(GetAllVehiclesRequest), typeof(GetVehiclesByNameRequest), typeof(GetVehicleByIdRequest))
        };        
    }
}

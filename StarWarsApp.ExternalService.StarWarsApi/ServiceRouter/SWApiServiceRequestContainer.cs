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

        #region Implemented Service Containers

        public static SWApiServiceRequestContainer[] AllContainers => new[] {FilmsContainer, PeopleContainer, PlanetsContainer, SpeciesContainer, StarshipsContainer, VehiclesContainer};

        public static readonly SWApiServiceRequestContainer FilmsContainer = new(new SWApiFilmService(), typeof(GetAllFilmsRequest), typeof(GetFilmsByTitleRequest), typeof(GetFilmByIdRequest));

        public static readonly SWApiServiceRequestContainer PeopleContainer = new(new SWApiPeopleService(), typeof(GetAllPeopleRequest), typeof(GetPeopleByNameRequest), typeof(GetPersonByIdRequest));

        public static readonly SWApiServiceRequestContainer PlanetsContainer = new(new SWApiPlanetService(), typeof(GetAllPlanetsRequest), typeof(GetPlanetsByNameRequest), typeof(GetPlanetByIdRequest));

        public static readonly SWApiServiceRequestContainer SpeciesContainer = new(new SWApiSpeciesService(), typeof(GetAllSpeciesRequest), typeof(GetSpeciesByNameRequest), typeof(GetSpeciesByIdRequest));

        public static readonly SWApiServiceRequestContainer StarshipsContainer = new(new SWApiStarshipService(), typeof(GetAllStarshipsRequest), typeof(GetStarshipsByNameRequest), typeof(GetStarshipByIdRequest));

        public static readonly SWApiServiceRequestContainer VehiclesContainer = new(new SWApiVehicleService(), typeof(GetAllVehiclesRequest), typeof(GetVehiclesByNameRequest), typeof(GetVehicleByIdRequest));

        #endregion
    }
}

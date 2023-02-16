using StarWarsApp.ExternalService.StarWarsApi.Services;

namespace StarWarsApp.ExternalService.StarWarsApi.ServiceRouter
{
    internal class SWApiServiceCollection
    {
        private readonly Dictionary<Type, object> _services;

        public SWApiServiceCollection()
        {
            var peopleService = new SWApiPeopleService();
            var filmService = new SWApiFilmService();
            var planetService = new SWApiPlanetService();
            var speciesService = new SWApiSpeciesService();
            var starshipService = new SWApiStarshipService();
            var vehicleService = new SWApiVehicleService();

            _services = new()
            {
                {typeof(GetAllPeopleRequest), peopleService },
                {typeof(GetPeopleByNameRequest), peopleService },
                {typeof(GetPersonByIdRequest), peopleService },

                {typeof(GetAllFilmsRequest), filmService },
                {typeof(GetFilmsByTitleRequest), filmService },
                {typeof(GetFilmByIdRequest), filmService },

                {typeof(GetAllPlanetsRequest), planetService },
                {typeof(GetPlanetsByNameRequest), planetService },
                {typeof(GetPlanetByIdRequest), planetService },

                {typeof(GetAllSpeciesRequest), speciesService },
                {typeof(GetSpeciesByNameRequest), speciesService },
                {typeof(GetSpeciesByIdRequest), speciesService },

                {typeof(GetAllStarshipsRequest), starshipService },
                {typeof(GetStarshipsByNameRequest), starshipService },
                {typeof(GetStarshipByIdRequest), starshipService },

                {typeof(GetAllVehicleRequest), vehicleService },
                {typeof(GetVehiclesByNameRequest), vehicleService },
                {typeof(GetVehicleByIdRequest), vehicleService },
            };
        }

        public async Task<TResponse> CallService<TRequest, TResponse>(TRequest request) where TRequest : SWApiRequest<TResponse>
        {
            var service = _services.TryGetValue(request.GetType(), out var serviceInstance)
                                               ? serviceInstance : throw new ApplicationException($"No service registered for {nameof(request)}");

            if (service is ISWApiService<TRequest, TResponse> matchedService)
            {
                return await matchedService.GetResponseAsync(request);
            }

            throw new ApplicationException("Service was found but could not match to request.");
        }
    }
}

namespace StarWarsApp.ExternalService.StarWarsApi.Services
{
    internal class SWApiPlanetService : BaseSWApiService, 
        ISWApiService<GetAllPlanetsRequest, IEnumerable<SWApiPlanet>>,
        ISWApiService<GetPlanetsByNameRequest, IEnumerable<SWApiPlanet>>,
        ISWApiService<GetPlanetByIdRequest, SWApiPlanet?>
    {
        private const string _planetUrl = StarWarsApiBaseUrl + "planets/";

        public async Task<IEnumerable<SWApiPlanet>> GetResponseAsync(GetAllPlanetsRequest request) => await GetContentFromAllPagesAsync<SWApiPlanet>(_planetUrl);

        public async Task<IEnumerable<SWApiPlanet>> GetResponseAsync(GetPlanetsByNameRequest request) => await GetContentFromAllPagesAsync<SWApiPlanet>(_planetUrl + SearchParameter(request.Name));

        public async Task<SWApiPlanet?> GetResponseAsync(GetPlanetByIdRequest request) => await GetContentOrDefaultAsync<SWApiPlanet>(_planetUrl + request.Id);
    }
}

namespace StarWarsApp.ExternalService.StarWarsApi.Services
{
    internal class SWApiSpeciesService : BaseSWApiService, 
        ISWApiService<GetAllSpeciesRequest, IEnumerable<SWApiSpecies>>,
        ISWApiService<GetSpeciesByNameRequest, IEnumerable<SWApiSpecies>>,
        ISWApiService<GetSpeciesByIdRequest, SWApiSpecies?>
    {
        private const string _speciesUrl = StarWarsApiBaseUrl + "species/";

        public async Task<IEnumerable<SWApiSpecies>> GetResponseAsync(GetAllSpeciesRequest request) => await GetContentFromAllPagesAsync<SWApiSpecies>(_speciesUrl);

        public async Task<IEnumerable<SWApiSpecies>> GetResponseAsync(GetSpeciesByNameRequest request) => await GetContentFromAllPagesAsync<SWApiSpecies>(_speciesUrl + SearchParameter(request.Name));

        public async Task<SWApiSpecies?> GetResponseAsync(GetSpeciesByIdRequest request) => await GetContentOrDefaultAsync<SWApiSpecies>(_speciesUrl + request.Id);
    }
}

namespace StarWarsApp.ExternalService.StarWarsApi.Services
{
    internal class SWApiStarshipService : BaseSWApiService, 
        ISWApiService<GetAllStarshipsRequest, IEnumerable<SWApiStarship>>,
        ISWApiService<GetStarshipsByNameRequest, IEnumerable<SWApiStarship>>,
        ISWApiService<GetStarshipByIdRequest, SWApiStarship?>
    {
        private const string _starshipsUrl = StarWarsApiBaseUrl + "starships/";

        public async Task<IEnumerable<SWApiStarship>> GetResponseAsync(GetAllStarshipsRequest request) => await GetContentFromAllPagesAsync<SWApiStarship>(_starshipsUrl);

        public async Task<IEnumerable<SWApiStarship>> GetResponseAsync(GetStarshipsByNameRequest request) => await GetContentFromAllPagesAsync<SWApiStarship>(_starshipsUrl + SearchParameter(request.Name));

        public async Task<SWApiStarship?> GetResponseAsync(GetStarshipByIdRequest request) => await GetContentOrDefaultAsync<SWApiStarship>(_starshipsUrl + request.Id);
    }
}

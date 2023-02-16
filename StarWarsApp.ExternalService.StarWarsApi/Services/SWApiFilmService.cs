namespace StarWarsApp.ExternalService.StarWarsApi.Services
{
    internal class SWApiFilmService : BaseSWApiService,
        ISWApiService<GetAllFilmsRequest, IEnumerable<SWApiFilm>>,
        ISWApiService<GetFilmsByTitleRequest, IEnumerable<SWApiFilm>>,
        ISWApiService<GetFilmByIdRequest, SWApiFilm?>
    {
        private const string _filmsUrl = StarWarsApiBaseUrl + "films/";

        public async Task<IEnumerable<SWApiFilm>> GetResponseAsync(GetAllFilmsRequest request) => await GetContentFromAllPagesAsync<SWApiFilm>(_filmsUrl);

        public async Task<IEnumerable<SWApiFilm>> GetResponseAsync(GetFilmsByTitleRequest request) => await GetContentFromAllPagesAsync<SWApiFilm>(_filmsUrl + SearchParameter(request.Name));

        public async Task<SWApiFilm?> GetResponseAsync(GetFilmByIdRequest request) => await GetContentOrDefaultAsync<SWApiFilm>(_filmsUrl + request.Id);
    }
}

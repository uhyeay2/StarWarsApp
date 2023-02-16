namespace StarWarsApp.ExternalService.StarWarsApi.Services
{
    internal class SWApiPeopleService : BaseSWApiService,
        ISWApiService<GetAllPeopleRequest, IEnumerable<SWApiPerson>>,
        ISWApiService<GetPeopleByNameRequest, IEnumerable<SWApiPerson>>,
        ISWApiService<GetPersonByIdRequest, SWApiPerson?>
    {
        private const string _peopleUrl = StarWarsApiBaseUrl + "people/";

        public async Task<IEnumerable<SWApiPerson>> GetResponseAsync(GetAllPeopleRequest request) => await GetContentFromAllPagesAsync<SWApiPerson>(_peopleUrl);

        public async Task<IEnumerable<SWApiPerson>> GetResponseAsync(GetPeopleByNameRequest request) => await GetContentFromAllPagesAsync<SWApiPerson>(_peopleUrl + SearchParameter(request.Name));

        public async Task<SWApiPerson?> GetResponseAsync(GetPersonByIdRequest request) => await GetContentOrDefaultAsync<SWApiPerson>(_peopleUrl + request.Id);
    }
}

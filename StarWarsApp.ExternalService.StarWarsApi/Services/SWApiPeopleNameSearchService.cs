namespace StarWarsApp.ExternalService.StarWarsApi.Services
{
    internal class GetPeopleByNameRequest : ExternalServiceRequest<IEnumerable<Person>>
    {
        public GetPeopleByNameRequest(string name) => Name = name;

        public string Name { get; set; }
    }

    internal class SWApiPeopleNameSearchService : SWApiPeopleService, IExternalService<GetPeopleByNameRequest, IEnumerable<Person>>
    {
        public async Task<IEnumerable<Person>> GetResponseAsync(GetPeopleByNameRequest request) => await GetPeople(PeopleUrl + $"?search={request.Name}");
    }
}

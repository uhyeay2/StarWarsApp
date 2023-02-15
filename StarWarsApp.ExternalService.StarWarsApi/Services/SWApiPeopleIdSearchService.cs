namespace StarWarsApp.ExternalService.StarWarsApi.Services
{
    internal class GetPersonByIdRequest : ExternalServiceRequest<Person?>
    {
        public GetPersonByIdRequest(int id) => Id = id;

        public int Id { get; }
    }

    internal class SWApiPeopleIdSearchService : SWApiPeopleService, IExternalService<GetPersonByIdRequest, Person?>
    {
        public async Task<Person?> GetResponseAsync(GetPersonByIdRequest request) => (await GetContentOrDefault<SWApiPerson>(PeopleUrl + request.Id))?.ParsePerson();
    }
}

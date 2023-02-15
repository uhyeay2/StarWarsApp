using StarWarsApp.ExternalService.StarWarsApi.Services;

namespace StarWarsApp.ExternalService.StarWarsApi.ServiceRouter
{
    internal class SWApiServiceRouter : ISWApiServiceRouter
    {
        private readonly SWApiServiceCollection _services = new();

        public async Task<IEnumerable<Person>> GetAllPeopleAsync() => await _services.CallService<GetAllPeopleRequest, IEnumerable<Person>>(new GetAllPeopleRequest());

        public async Task<IEnumerable<Person>> GetPeopleByNameAsync(string name) => await _services.CallService<GetPeopleByNameRequest, IEnumerable<Person>>(new GetPeopleByNameRequest(name));

        public async Task<Person?> GetPersonByIdAsync(int id) => await _services.CallService<GetPersonByIdRequest, Person?>(new GetPersonByIdRequest(id));
    }
}

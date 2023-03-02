using StarWarsApp.Domain.Models;
using StarWarsApp.ExternalService.StarWarsApi.Interfaces;
using StarWarsApp.ExternalService.StarWarsApi.Responses;
using StarWarsApp.Services.Interfaces;

namespace StarWarsApp.Services.StarWarsApi.Services
{
    internal class SWApiPersonService : BaseSWApiService, ISWApiPersonService
    {
        private readonly ISWApiOrchestrator _starWarsApiOrchestrator;

        private readonly ISWApiServiceRouter _starWarsApi;
        
        private readonly IModelBuilder<SWApiPerson, Person> _modelBuilder;

        public SWApiPersonService(ISWApiOrchestrator starWarsApiOrchestrator, ISWApiServiceRouter starWarsApiRouter, IModelBuilder<SWApiPerson, Person> modelBuilder)
        : base(starWarsApiOrchestrator, starWarsApiRouter)
        {
            _starWarsApiOrchestrator = starWarsApiOrchestrator;
            _starWarsApi = starWarsApiRouter;
            _modelBuilder = modelBuilder;
        }

        public IEnumerable<Person> GetAllPeople() => _starWarsApiOrchestrator.GetAllPeople().Select(_modelBuilder.Build);

        public async Task<IEnumerable<Person>> GetPeopleByNameAsync(string name) => (await _starWarsApi.GetPeopleByNameAsync(name)).Select(_modelBuilder.Build);

        public async Task<Person?> GetPersonByIdAsync(int id)
        {
            var person = await _starWarsApi.GetPersonByIdAsync(id);

            return person == null ? null : _modelBuilder.Build(person);
        }
    }
}

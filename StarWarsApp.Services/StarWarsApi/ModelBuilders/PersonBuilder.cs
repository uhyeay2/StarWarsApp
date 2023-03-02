using StarWarsApp.Domain.Models;
using StarWarsApp.Services.Extensions;
using StarWarsApp.ExternalService.StarWarsApi.Responses;
using StarWarsApp.Services.Interfaces;

namespace StarWarsApp.Services.StarWarsApi.ModelBuilders
{
    internal class PersonBuilder : IModelBuilder<SWApiPerson, Person>
    {
        private readonly ISWApiOrchestrator _starWarsApi;

        private readonly IModelBuilder<SWApiPlanet, Planet> _planetBuilder;

        public PersonBuilder(ISWApiOrchestrator sWApiOrchestrator, IModelBuilder<SWApiPlanet, Planet> planetBuilder)
        {
            _starWarsApi = sWApiOrchestrator;
            _planetBuilder = planetBuilder;
        }

        public Person Build(SWApiPerson person) => new ( person.url.ParseStarWarsApiId(), person.name, 
                                                         person.height.GetValueOrDefaultToUnknown(),      person.mass.GetValueOrDefaultToUnknown(), 
                                                         person.hair_color.GetValueOrDefaultToUnknown(),  person.eye_color.GetValueOrDefaultToUnknown(), 
                                                         person.gender.GetValueOrDefaultToUnknown(),      person.birth_year.GetValueOrDefaultToUnknown(),
                                                         GetHomePlanet(person.homeworld));

        private Planet? GetHomePlanet(string? homePlanetUrl)
        {
            var homePlanet = _starWarsApi.GetAllPlanets().FirstOrDefault(_ => _.url == homePlanetUrl);

            return homePlanet == null ? null : _planetBuilder.Build(homePlanet);
        }
    }
}

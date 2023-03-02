using StarWarsApp.Domain.Models;
using StarWarsApp.ExternalService.StarWarsApi.Responses;
using StarWarsApp.Services.Extensions;
using StarWarsApp.Services.Interfaces;

namespace StarWarsApp.Services.StarWarsApi.ModelBuilders
{
    internal class PlanetBuilder : IModelBuilder<SWApiPlanet, Planet>
    {
        public Planet Build(SWApiPlanet input) => new (input.url.ParseStarWarsApiId(),      input.name, 
                                                       input.rotation_period.GetValueOrDefaultToUnknown(),  input.orbital_period.GetValueOrDefaultToUnknown(), 
                                                       input.climate.GetValueOrDefaultToUnknown(),          input.gravity.GetValueOrDefaultToUnknown(), 
                                                       input.terrain.GetValueOrDefaultToUnknown(),          input.surface_water.GetValueOrDefaultToUnknown(), 
                                                       input.population.GetValueOrDefaultToUnknown());
    }
}

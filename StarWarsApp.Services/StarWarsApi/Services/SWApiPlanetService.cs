using StarWarsApp.Domain.Models;
using StarWarsApp.ExternalService.StarWarsApi.Interfaces;
using StarWarsApp.ExternalService.StarWarsApi.Responses;
using StarWarsApp.Services.Interfaces;

namespace StarWarsApp.Services.StarWarsApi.Services
{
    internal class SWApiPlanetService : BaseSWApiService, ISWApiPlanetService
    {
        private readonly IModelBuilder<SWApiPlanet, Planet> _modelBuilder;

        public SWApiPlanetService(ISWApiOrchestrator orchestrator, ISWApiServiceRouter router, IModelBuilder<SWApiPlanet, Planet> modelBuilder) : base(orchestrator, router)
        {
            _modelBuilder = modelBuilder;
        }

        public IEnumerable<Planet> GetAllPlanets() => _orchestrator.GetAllPlanets().Select(_modelBuilder.Build);

        public async Task<Planet?> GetPlanetByIdAsync(int id)
        {
            var planet = await _router.GetPlanetByIdAsync(id);

            return planet == null ? null : _modelBuilder.Build(planet);
        }
            
    }
}

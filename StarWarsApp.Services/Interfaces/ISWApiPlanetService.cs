using StarWarsApp.Domain.Models;

namespace StarWarsApp.Services.Interfaces
{
    public interface ISWApiPlanetService : ISWApiService
    {
        public IEnumerable<Planet> GetAllPlanets();

        public Task<Planet?> GetPlanetByIdAsync(int id);
    }
}

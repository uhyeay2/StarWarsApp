using StarWarsApp.ExternalService.StarWarsApi.Responses;

namespace StarWarsApp.Services.Interfaces
{
    public interface ISWApiOrchestrator
    {
        public long GetRefreshCount();

        public Task RefreshDataAsync();

        public DateTime GetLastUpdateDateTimeUTC();

        public IEnumerable<SWApiPerson> GetAllPeople();

        public IEnumerable<SWApiPlanet> GetAllPlanets();
    }
}

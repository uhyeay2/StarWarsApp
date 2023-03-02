using StarWarsApp.ExternalService.StarWarsApi.Interfaces;
using StarWarsApp.ExternalService.StarWarsApi.Responses;
using StarWarsApp.Services.Interfaces;

namespace StarWarsApp.Services.StarWarsApi
{
    internal class StarWarsApiOrchestrator : ISWApiOrchestrator
    {
        private readonly ISWApiServiceRouter _starWarsApi;

        private long _refreshCount = 0;

        private DateTime _lastUpdatedDateTimeUTC;

        private IEnumerable<SWApiPerson> _people = Enumerable.Empty<SWApiPerson>();

        private IEnumerable<SWApiPlanet> _planets = Enumerable.Empty<SWApiPlanet>();

        public StarWarsApiOrchestrator(ISWApiServiceRouter starWarsApi)
        {
            _starWarsApi = starWarsApi;

            const int refreshIntervalInSeconds = 30;

            RefreshDataAsync().Wait();

            Task.Run(async () =>
            {
                while (true)
                {
                    await Task.Delay(TimeSpan.FromSeconds(refreshIntervalInSeconds));

                    await RefreshDataAsync();
                }
            });
        } 

        public IEnumerable<SWApiPerson> GetAllPeople() => _people;

        public IEnumerable<SWApiPlanet> GetAllPlanets() => _planets;

        public DateTime GetLastUpdateDateTimeUTC() => _lastUpdatedDateTimeUTC;

        public long GetRefreshCount() => _refreshCount;

        public async Task RefreshDataAsync()
        {
            await Task.WhenAll( RefreshPeople(), RefreshPlanets() );
            _lastUpdatedDateTimeUTC = DateTime.UtcNow;
            _refreshCount++;
        }

        private async Task RefreshPeople() => _people = await _starWarsApi.GetAllPeopleAsync();

        private async Task RefreshPlanets() => _planets = await _starWarsApi.GetAllPlanetsAsync();
    }
}

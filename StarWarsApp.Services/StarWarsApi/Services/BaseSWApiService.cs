using StarWarsApp.ExternalService.StarWarsApi.Interfaces;
using StarWarsApp.Services.Interfaces;

namespace StarWarsApp.Services.StarWarsApi.Services
{
    internal abstract class BaseSWApiService : ISWApiService
    {
        protected readonly ISWApiOrchestrator _orchestrator;
        protected readonly ISWApiServiceRouter _router;

        public BaseSWApiService(ISWApiOrchestrator orchestrator, ISWApiServiceRouter router)
        {
            _orchestrator = orchestrator;
            _router = router;
        }

        public DateTime GetLastUpdateDateTimeUTC() => _orchestrator.GetLastUpdateDateTimeUTC();

        public long GetRefreshCount() => _orchestrator.GetRefreshCount();

        public Task RefreshDataAsync() => _orchestrator.RefreshDataAsync();
    }
}

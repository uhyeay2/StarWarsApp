using StarWarsApp.ExternalService.StarWarsApi.Services;

namespace StarWarsApp.ExternalService.StarWarsApi.ServiceRouter
{
    internal class SWApiServiceCollection
    {
        private readonly Dictionary<Type, object> _services;

        public SWApiServiceCollection()
        {
            _services = new()
            {
                {typeof(GetAllPeopleRequest), new SWApiPeopleService() },
                {typeof(GetPeopleByNameRequest), new SWApiPeopleNameSearchService() },
                {typeof(GetPersonByIdRequest), new SWApiPeopleIdSearchService() }
            };
        }

        public async Task<TResponse> CallService<TRequest, TResponse>(TRequest request) where TRequest : ExternalServiceRequest<TResponse>
        {
            var service = _services.TryGetValue(request.GetType(), out var serviceInstance)
                                               ? serviceInstance : throw new ApplicationException($"No service registered for {nameof(request)}");

            if (service is IExternalService<TRequest, TResponse> matchedService)
            {
                return await matchedService.GetResponseAsync(request);
            }

            throw new ApplicationException("Service was found but could not match to request.");
        }
    }
}

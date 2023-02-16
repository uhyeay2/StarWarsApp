namespace StarWarsApp.ExternalService.StarWarsApi.ServiceRouter
{
    internal class SWApiServiceCollection
    {
        private readonly Dictionary<Type, object> _services;

        public SWApiServiceCollection(params SWApiServiceRequestContainer[] services)
        {
            _services = new();

            foreach (var service in services)
            {
                AddService(service);
            }
        }

        public SWApiServiceCollection() : this( SWApiServiceRequestContainer.AllContainers ) { }

        private void AddService(SWApiServiceRequestContainer service)
        {
            if(service == null) throw new ArgumentNullException(nameof(service));

            if (service.Requests.Any())
            {
                foreach (var request in service.Requests)
                {
                    _services.TryAdd(request, service.Implementation);
                }
            }
        }

        public async Task<TResponse> CallService<TRequest, TResponse>(TRequest request) where TRequest : SWApiRequest<TResponse>
        {
            var service = _services.TryGetValue(request.GetType(), out var serviceInstance)
                                               ? serviceInstance : throw new ApplicationException($"No service registered for {nameof(request)}");

            if (service is ISWApiService<TRequest, TResponse> matchedService)
            {
                return await matchedService.GetResponseAsync(request);
            }

            throw new ApplicationException("Service was found but could not match to request.");
        }
    }
}

namespace StarWarsApp.ExternalService.StarWarsApi.Interfaces
{
    internal interface ISWApiService<TRequest, TResponse> where TRequest : SWApiRequest<TResponse>
    {
        public Task<TResponse> GetResponseAsync(TRequest request);
    }
}

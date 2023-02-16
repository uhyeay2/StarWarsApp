namespace StarWarsApp.ExternalService.StarWarsApi.Interfaces
{
    public interface ISWApiService<TRequest, TResponse> where TRequest : SWApiRequest<TResponse>
    {
        public Task<TResponse> GetResponseAsync(TRequest request);
    }
}

namespace StarWarsApp.Domain.Interfaces
{
    public interface IExternalService<TRequest, TResponse> where TRequest : ExternalServiceRequest<TResponse> 
    {
        public Task<TResponse> GetResponseAsync(TRequest request);
    }

    public abstract class ExternalServiceRequest<TResponse> { }
}

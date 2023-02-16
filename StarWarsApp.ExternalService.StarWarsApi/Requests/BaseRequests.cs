namespace StarWarsApp.ExternalService.StarWarsApi.Requests
{
    public abstract class SWApiRequest<TResponse> { }

    internal abstract class GetAllRequest<TResponse> : SWApiRequest<IEnumerable<TResponse>> { }

    internal abstract class GetByIdRequest<TResponse> : SWApiRequest<TResponse> 
    {
        public GetByIdRequest(int id) => Id = id;

        public int Id { get; }
    }

    internal abstract class GetByNameRequest<TResponse> : SWApiRequest<IEnumerable<TResponse>>
    {
        public GetByNameRequest(string name) => Name = name;

        public string Name { get; }
    }
}

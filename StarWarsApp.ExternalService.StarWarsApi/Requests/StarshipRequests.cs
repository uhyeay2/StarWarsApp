namespace StarWarsApp.ExternalService.StarWarsApi.Requests
{
    internal class GetAllStarshipsRequest : GetAllRequest<SWApiStarship> { }

    internal class GetStarshipsByNameRequest: GetByNameRequest<SWApiStarship>
    {
        public GetStarshipsByNameRequest(string name) : base(name) { }
    }

    internal class GetStarshipByIdRequest: GetByIdRequest<SWApiStarship?>
    {
        public GetStarshipByIdRequest(int id) : base(id) { }
    }
}

namespace StarWarsApp.ExternalService.StarWarsApi.Requests
{
    internal class GetAllSpeciesRequest : GetAllRequest<SWApiSpecies> { }

    internal class GetSpeciesByNameRequest : GetByNameRequest<SWApiSpecies>
    {
        public GetSpeciesByNameRequest(string name) : base(name) { }
    }

    internal class GetSpeciesByIdRequest : GetByIdRequest<SWApiSpecies?>
    {
        public GetSpeciesByIdRequest(int id) : base(id) { }
    }
}

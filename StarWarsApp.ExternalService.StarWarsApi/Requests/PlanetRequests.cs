namespace StarWarsApp.ExternalService.StarWarsApi.Requests
{
    internal class GetAllPlanetsRequest : GetAllRequest<SWApiPlanet> { }

    internal class GetPlanetsByNameRequest : GetByNameRequest<SWApiPlanet>
    {
        public GetPlanetsByNameRequest(string name) : base(name) { }
    }

    internal class GetPlanetByIdRequest : GetByIdRequest<SWApiPlanet?>
    {
        public GetPlanetByIdRequest(int id) : base(id) { }
    }
}

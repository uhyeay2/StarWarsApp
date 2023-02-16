namespace StarWarsApp.ExternalService.StarWarsApi.Requests
{
    internal class GetAllPeopleRequest : GetAllRequest<SWApiPerson> { }

    internal class GetPeopleByNameRequest : GetByNameRequest<SWApiPerson>
    {
        public GetPeopleByNameRequest(string name) : base(name) { }
    }

    internal class GetPersonByIdRequest : GetByIdRequest<SWApiPerson?>
    {
        public GetPersonByIdRequest(int id) : base(id) { }
    }
}

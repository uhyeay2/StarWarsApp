namespace StarWarsApp.ExternalService.StarWarsApi.Requests
{
    internal class GetAllVehiclesRequest : GetAllRequest<SWApiVehicle> { }

    internal class GetVehiclesByNameRequest : GetByNameRequest<SWApiVehicle>
    {
        public GetVehiclesByNameRequest(string name) : base(name) { }
    }

    internal class GetVehicleByIdRequest : GetByIdRequest<SWApiVehicle?>
    {
        public GetVehicleByIdRequest(int id) : base(id) { }
    }
}

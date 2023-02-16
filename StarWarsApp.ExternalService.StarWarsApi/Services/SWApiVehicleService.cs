namespace StarWarsApp.ExternalService.StarWarsApi.Services
{
    internal class GetAllVehicleRequest : GetAllRequest<SWApiVehicle> { }

    internal class SWApiVehicleService : BaseSWApiService, 
        ISWApiService<GetAllVehicleRequest, IEnumerable<SWApiVehicle>>,
        ISWApiService<GetVehiclesByNameRequest, IEnumerable<SWApiVehicle>>,
        ISWApiService<GetVehicleByIdRequest, SWApiVehicle?>
    {
        private const string _vehiclesUrl = StarWarsApiBaseUrl + "vehicles/";

        public async Task<IEnumerable<SWApiVehicle>> GetResponseAsync(GetAllVehicleRequest request) => await GetContentFromAllPagesAsync<SWApiVehicle>(_vehiclesUrl);

        public async Task<IEnumerable<SWApiVehicle>> GetResponseAsync(GetVehiclesByNameRequest request) => await GetContentFromAllPagesAsync<SWApiVehicle>(_vehiclesUrl + SearchParameter(request.Name));

        public async Task<SWApiVehicle?> GetResponseAsync(GetVehicleByIdRequest request) => await GetContentOrDefaultAsync<SWApiVehicle>(_vehiclesUrl + request.Id);
    }
}

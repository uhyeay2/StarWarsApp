namespace StarWarsApp.ExternalService.StarWarsApi.ServiceRouter
{
    internal class SWApiServiceRouter : ISWApiServiceRouter
    {
        private readonly SWApiServiceCollection _services = new();

        #region Films

        public async Task<IEnumerable<SWApiFilm>> GetAllFilmsAsync() => await _services.CallService<GetAllFilmsRequest, IEnumerable<SWApiFilm>>(new GetAllFilmsRequest());
        public async Task<SWApiFilm?> GetFilmByIdAsync(int id) => await _services.CallService<GetFilmByIdRequest, SWApiFilm?>(new GetFilmByIdRequest(id));
        public async Task<IEnumerable<SWApiFilm>> GetFilmsByTitleAsync(string title) => await _services.CallService<GetFilmsByTitleRequest, IEnumerable<SWApiFilm>>(new GetFilmsByTitleRequest(title));

        #endregion

        #region People

        public async Task<IEnumerable<SWApiPerson>> GetAllPeopleAsync() => await _services.CallService<GetAllPeopleRequest, IEnumerable<SWApiPerson>>(new GetAllPeopleRequest());
        public async Task<IEnumerable<SWApiPerson>> GetPeopleByNameAsync(string name) => await _services.CallService<GetPeopleByNameRequest, IEnumerable<SWApiPerson>>(new GetPeopleByNameRequest(name));
        public async Task<SWApiPerson?> GetPersonByIdAsync(int id) => await _services.CallService<GetPersonByIdRequest, SWApiPerson?>(new GetPersonByIdRequest(id));

        #endregion

        #region Planets

        public async Task<IEnumerable<SWApiPlanet>> GetAllPlanetsAsync() => await _services.CallService<GetAllPlanetsRequest, IEnumerable<SWApiPlanet>>(new GetAllPlanetsRequest());
        public async Task<IEnumerable<SWApiPlanet>> GetPlanetsByNameAsync(string name) => await _services.CallService<GetPlanetsByNameRequest, IEnumerable<SWApiPlanet>>(new GetPlanetsByNameRequest(name));
        public async Task<SWApiPlanet?> GetPlanetByIdAsync(int id) => await _services.CallService<GetPlanetByIdRequest, SWApiPlanet?>(new GetPlanetByIdRequest(id));
            
        #endregion

        #region Species

        public async Task<IEnumerable<SWApiSpecies>> GetAllSpeciesAsync() => await _services.CallService<GetAllSpeciesRequest, IEnumerable<SWApiSpecies>>(new GetAllSpeciesRequest());
        public async Task<IEnumerable<SWApiSpecies>> GetSpeciesByNameAsync(string name) => await _services.CallService<GetSpeciesByNameRequest, IEnumerable<SWApiSpecies>>(new GetSpeciesByNameRequest(name));
        public async Task<SWApiSpecies?> GetSpeciesByIdAsync(int id) => await _services.CallService<GetSpeciesByIdRequest, SWApiSpecies?>(new GetSpeciesByIdRequest(id));

        #endregion

        #region Starships

        public async Task<IEnumerable<SWApiStarship>> GetAllStarshipsAsync() => await _services.CallService<GetAllStarshipsRequest, IEnumerable<SWApiStarship>>(new GetAllStarshipsRequest());
        public async Task<IEnumerable<SWApiStarship>> GetStarshipsByNameAsync(string name) => await _services.CallService<GetStarshipsByNameRequest, IEnumerable<SWApiStarship>>(new GetStarshipsByNameRequest(name));
        public async Task<SWApiStarship?> GetStarshipByIdAsync(int id) => await _services.CallService<GetStarshipByIdRequest, SWApiStarship?>(new GetStarshipByIdRequest(id));
        
        #endregion

        #region Vehicles

        public async Task<IEnumerable<SWApiVehicle>> GetAllVehiclesAsync() => await _services.CallService<GetAllVehiclesRequest, IEnumerable<SWApiVehicle>>(new GetAllVehiclesRequest());
        public Task<IEnumerable<SWApiVehicle>> GetVehiclesByNameAsync(string name) => _services.CallService<GetVehiclesByNameRequest, IEnumerable<SWApiVehicle>>(new GetVehiclesByNameRequest(name));
        public async Task<SWApiVehicle?> GetVehicleByIdAsync(int id) => await _services.CallService<GetVehicleByIdRequest, SWApiVehicle?>(new GetVehicleByIdRequest(id));

        #endregion
    }
}

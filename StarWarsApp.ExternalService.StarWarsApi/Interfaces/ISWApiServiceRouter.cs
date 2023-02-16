namespace StarWarsApp.ExternalService.StarWarsApi.Interfaces
{
    public interface ISWApiServiceRouter
    {
        #region Films

        public Task<IEnumerable<SWApiFilm>> GetAllFilmsAsync();

        public Task<IEnumerable<SWApiFilm>> GetFilmsByTitleAsync(string name);

        public Task<SWApiFilm?> GetFilmByIdAsync(int id);

        #endregion

        #region People 

        public Task<IEnumerable<SWApiPerson>> GetAllPeopleAsync();

        public Task<IEnumerable<SWApiPerson>> GetPeopleByNameAsync(string name);

        public Task<SWApiPerson?> GetPersonByIdAsync(int id);

        #endregion

        #region Planets

        public Task<IEnumerable<SWApiPlanet>> GetAllPlanetsAsync();

        public Task<IEnumerable<SWApiPlanet>> GetPlanetsByNameAsync(string name);

        public Task<SWApiPlanet?> GetPlanetByIdAsync(int id);

        #endregion

        #region Species

        public Task<IEnumerable<SWApiSpecies>> GetAllSpeciesAsync();

        public Task<IEnumerable<SWApiSpecies>> GetSpeciesByNameAsync(string name);

        public Task<SWApiSpecies?> GetSpeciesByIdAsync(int id);

        #endregion

        #region Starships

        public Task<IEnumerable<SWApiStarship>> GetAllStarshipsAsync();

        public Task<IEnumerable<SWApiStarship>> GetStarshipsByNameAsync(string name);

        public Task<SWApiStarship?> GetStarshipByIdAsync(int id);

        #endregion

        #region Vehicles

        public Task<IEnumerable<SWApiVehicle>> GetAllVehiclesAsync();

        public Task<IEnumerable<SWApiVehicle>> GetVehiclesByNameAsync(string name);

        public Task<SWApiVehicle?> GetVehicleByIdAsync(int id);

        #endregion
    }
}

using StarWarsApp.ExternalService.StarWarsApi.Interfaces;
using StarWarsApp.ExternalService.StarWarsApi.ServiceRouter;

namespace StarWarsApp.ExternalService.StarWarsApi.Tests.ServiceRouterTests
{
    public class ServiceRouterIntegrationTests
    {
        private readonly ISWApiServiceRouter _serviceRouter = new SWApiServiceRouter();

        #region Film Tests

        [Fact]
        public async Task GetAllFilms_Should_NotReturn_EmptyCollection() => Assert.NotEmpty(await _serviceRouter.GetAllFilmsAsync());

        [Fact]
        public async Task GetFilmByTitle_Given_Empire_Should_Return_TheEmpireStrikesBack() => Assert.Contains("The Empire Strikes Back", (await _serviceRouter.GetFilmsByTitleAsync("Empire")).Select(x => x.title));

        [Fact]
        public async Task GetFilmById_Given_5_Should_Return_AttackOfTheClones() => Assert.Equal("Attack of the Clones", (await _serviceRouter.GetFilmByIdAsync(5))?.title);

        #endregion

        #region People Tests

        [Fact]
        public async Task GetAllPeople_Should_NotReturn_EmptyCollection() => Assert.NotEmpty(await _serviceRouter.GetAllPeopleAsync());

        [Fact]
        public async Task GetPeopleByName_Given_Skywalker_Should_Return_ThreePeople() => Assert.Equal(3, (await _serviceRouter.GetPeopleByNameAsync("Skywalker")).Count());

        [Fact]
        public async Task GetPersonById_Given_1_Should_Return_LukeSykwalker() => Assert.Equal("Luke Skywalker", (await _serviceRouter.GetPersonByIdAsync(1))?.name);

        #endregion

        #region Planet Tests

        [Fact]
        public async Task GetAllPlanets_Should_NotReturn_EmptyCollection() => Assert.NotEmpty( await _serviceRouter.GetAllPlanetsAsync());

        [Fact]
        public async Task GetPlanetsByName_Given_Coruscant_Should_NotReturn_Null() => Assert.NotNull(await _serviceRouter.GetPlanetsByNameAsync("Coruscant"));

        [Fact]
        public async Task GetPlanetById_Given_7_Should_Return_Endor() => Assert.Equal("Endor", (await _serviceRouter.GetPlanetByIdAsync(7))?.name);

        #endregion

        #region Species Tests

        [Fact]
        public async Task GetAllSpecies_Should_NotReturn_EmptyCollection() =>  Assert.NotEmpty( await _serviceRouter.GetAllSpeciesAsync());

        [Fact]
        public async Task GetSpeciesByName_Given_Ewo_Should_Return_Ewok() => Assert.Contains("Ewok", (await _serviceRouter.GetSpeciesByNameAsync("Ewo")).Select(x => x.name));

        [Fact]
        public async Task GetSpeciesById_Given_3_Should_Return_Wookie() => Assert.Equal("Wookie", (await _serviceRouter.GetSpeciesByIdAsync(3))?.name);

        #endregion

        #region Starship Tests

        [Fact]
        public async Task GetAllStarships_Should_NotReturn_EmptyCollection() => Assert.NotEmpty(await _serviceRouter.GetAllStarshipsAsync());

        [Fact]
        public async Task GetStarshipsByName_Given_Falcon_Should_Return_MillenniumFalcon() => Assert.Contains("Millennium Falcon", (await _serviceRouter.GetStarshipsByNameAsync("Falcon")).Select(x => x.name));

        [Fact]
        public async Task GetStarshipsById_Given_9_Should_Return_DeathStar() => Assert.Equal("Death Star", (await _serviceRouter.GetStarshipByIdAsync(9))?.name);

        #endregion

        #region Vehicle Tests

        [Fact]
        public async Task GetAllVehicles_Should_NotReturn_EmptyCollection() => Assert.NotEmpty(await _serviceRouter.GetAllVehiclesAsync());

        [Fact]
        public async Task GetVehiclesByName_Given_Droid_Should_Return_FourVehicles() => Assert.Equal(4, (await _serviceRouter.GetVehiclesByNameAsync("Droid")).Count());

        [Fact]
        public async Task GetVehicleById_Given_42_Should_Return_SithSpeeder() => Assert.Equal("Sith speeder", (await _serviceRouter.GetVehicleByIdAsync(42))?.name);

        #endregion
    }
}

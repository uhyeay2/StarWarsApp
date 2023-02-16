namespace StarWarsApp.ExternalService.StarWarsApi.Tests.ServiceTests
{
    public class SWApiPlanetServicesTests
    {
        private static readonly SWApiPlanetService _service = new();

        [Fact]
        public async Task GetAllPlanets_Should_NotReturn_EmptyCollection()
        {
            var result = await _service.GetResponseAsync(new GetAllPlanetsRequest());

            Assert.NotEmpty(result);
        }

        [Fact]
        public async Task GetPlanetsByName_Given_Coruscant_Should_NotReturn_Null()
        {
            var result = await _service.GetResponseAsync(new GetPlanetsByNameRequest("Coruscant"));

            Assert.NotNull(result);
        }

        [Fact]
        public async Task GetPlanetById_Given_7_Should_Return_Endor()
        {
            var result = await _service.GetResponseAsync(new GetPlanetByIdRequest(7));

            Assert.Equal("Endor", result?.name);
        }
    }
}

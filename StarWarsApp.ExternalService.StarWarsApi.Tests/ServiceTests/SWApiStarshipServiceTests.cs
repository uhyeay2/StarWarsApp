namespace StarWarsApp.ExternalService.StarWarsApi.Tests.ServiceTests
{
    public class SWApiStarshipServiceTests
    {
        private static readonly SWApiStarshipService _service = new();

        [Fact]
        public async Task GetAllStarships_Should_NotReturn_EmptyCollection()
        {
            var result = await _service.GetResponseAsync(new GetAllStarshipsRequest());

            Assert.NotEmpty(result);
        }

        [Fact]
        public async Task GetStarshipsByName_Given_Falcon_Should_Return_MillenniumFalcon()
        {
            var result = await _service.GetResponseAsync(new GetStarshipsByNameRequest("Falcon"));

            Assert.Contains("Millennium Falcon", result.Select(x => x.name));
        }

        [Fact]
        public async Task GetStarshipsById_Given_9_Should_Return_DeathStar()
        {
            var result = await _service.GetResponseAsync(new GetStarshipByIdRequest(9));

            Assert.Equal("Death Star", result?.name);
        }
    }
}

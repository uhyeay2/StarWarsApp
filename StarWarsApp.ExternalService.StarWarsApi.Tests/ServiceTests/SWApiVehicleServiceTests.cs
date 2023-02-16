namespace StarWarsApp.ExternalService.StarWarsApi.Tests.ServiceTests
{
    public class SWApiVehicleServiceTests
    {
        private static readonly SWApiVehicleService _service = new();

        [Fact]
        public async Task GetAllVehicles_Should_NotReturn_EmptyCollection()
        {
            var result = await _service.GetResponseAsync(new GetAllVehiclesRequest());

            Assert.NotEmpty(result);
        }

        [Fact]
        public async Task GetVehiclesByName_Given_Droid_Should_Return_FourVehicles()
        {
            var result = await _service.GetResponseAsync(new GetVehiclesByNameRequest("Droid"));

            Assert.Equal(4, result.Count());
        }

        [Fact]
        public async Task GetVehicleById_Given_42_Should_Return_SithSpeeder()
        {
            var result = await _service.GetResponseAsync(new GetVehicleByIdRequest(42));

            Assert.Equal("Sith speeder", result?.name);
        }
    }
}

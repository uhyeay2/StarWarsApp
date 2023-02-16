namespace StarWarsApp.ExternalService.StarWarsApi.Tests.ServiceTests
{
    public class SWApiSpeciesServicesTests
    {
        private static readonly SWApiSpeciesService _service = new();

        [Fact]
        public async Task GetAllSpecies_Should_NotReturn_EmptyCollection()
        {
            var result = await _service.GetResponseAsync(new GetAllSpeciesRequest());

            Assert.NotEmpty(result);
        }

        [Fact]
        public async Task GetSpeciesByName_Given_Ewo_Should_Return_Ewok()
        {
            var result = await _service.GetResponseAsync(new GetSpeciesByNameRequest("Ewo"));

            Assert.Contains("Ewok", result.Select(x => x.name));
        }

        [Fact]
        public async Task GetSpeciesById_Given_3_Should_Return_Wookie()
        {
            var result = await _service.GetResponseAsync(new GetSpeciesByIdRequest(3));

            Assert.Equal("Wookie", result?.name);
        }
    }
}

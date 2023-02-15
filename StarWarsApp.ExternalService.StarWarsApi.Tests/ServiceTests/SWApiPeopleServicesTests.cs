using StarWarsApp.ExternalService.StarWarsApi.Services;

namespace StarWarsApp.ExternalService.StarWarsApi.Tests.ClientTests
{
    public class SWApiPeopleServicesTests
    {
        [Fact]
        public async Task SWApiPeopleService_Should_ReturnListOfPeople()
        {
            var service = new SWApiPeopleService();

            var result = await service.GetResponseAsync(new());

            Assert.NotEmpty(result);
        }

        [Fact]
        public async Task SWApiPeopleNameSearchService_Given_Skywalker_Should_ReturnThreePeople()
        {
            var service = new SWApiPeopleNameSearchService();

            var result = await service.GetResponseAsync(new("Skywalker"));

            Assert.Equal(3, result.Count());
        }

        [Fact]
        public async Task SWApiPeopleIdSearchService_Given_1_Should_ReturnLukeSykwalker()
        {
            var service = new SWApiPeopleIdSearchService();

            var result = await service.GetResponseAsync(new(1));

            Assert.Equal("Luke Skywalker", result?.Name);
        }
    }
}

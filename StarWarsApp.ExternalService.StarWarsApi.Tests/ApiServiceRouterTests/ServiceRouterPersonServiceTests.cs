using StarWarsApp.Domain.Interfaces;

namespace StarWarsApp.ExternalService.StarWarsApi.Tests.ApiServiceRouterTests
{
    public class ServiceRouterPersonServiceTests
    {
        private static readonly ISWApiServiceRouter _router = new SWApiServiceRouter();

        [Fact]
        public async Task GetAllPeopleService_Given_GetAllPeople_Should_ReturnListOfPeople()
        {
            var result = await _router.GetAllPeopleAsync();

            Assert.NotEmpty(result);
        }

        [Fact]
        public async Task GetPeopleByNameService_Given_Skywalker_Should_Return3People()
        {
            var result = await _router.GetPeopleByNameAsync("Skywalker");

            Assert.Equal(3, result.Count());
        }
    }
}

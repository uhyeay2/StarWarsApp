namespace StarWarsApp.ExternalService.StarWarsApi.Tests.ServiceTests
{
    public class SWApiPeopleServicesTests
    {
        private readonly SWApiPeopleService _service = new();

        [Fact]
        public async Task GetAllPeople_Should_NotReturn_EmptyCollection()
        {
            var result = await _service.GetResponseAsync(new GetAllPeopleRequest());

            Assert.NotEmpty(result);
        }

        [Fact]
        public async Task GetPeopleByName_Given_Skywalker_Should_Return_ThreePeople()
        {

            var result = await _service.GetResponseAsync(new GetPeopleByNameRequest("Skywalker"));

            Assert.Equal(3, result.Count());
        }

        [Fact]
        public async Task GetPersonById_Given_1_Should_Return_LukeSykwalker()
        {
            var result = await _service.GetResponseAsync(new GetPersonByIdRequest(1));

            Assert.Equal("Luke Skywalker", result?.name);
        }
    }
}

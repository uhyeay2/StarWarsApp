namespace StarWarsApp.ExternalService.StarWarsApi.Tests.ServiceTests
{
    public class SWApiFilmServiceTests
    {
        private readonly SWApiFilmService _service = new();

        [Fact]
        public async Task GetAllFilms_Should_NotReturn_EmptyCollection()
        {
            var result = await _service.GetResponseAsync(new GetAllFilmsRequest());

            Assert.NotEmpty(result);
        }

        [Fact]
        public async Task GetFilmByTitle_Given_Empire_Should_Return_TheEmpireStrikesBack()
        {
            var result = await _service.GetResponseAsync(new GetFilmsByTitleRequest("Empire"));

            var titlesFound = result.Select(x => x.title);

            Assert.Contains("The Empire Strikes Back", titlesFound);
        }

        [Fact]
        public async Task GetFilmById_Given_5_Should_Return_AttackOfTheClones()
        {
            var result = await _service.GetResponseAsync(new GetFilmByIdRequest(5));

            Assert.Equal("Attack of the Clones", result?.title);
        }
    }
}

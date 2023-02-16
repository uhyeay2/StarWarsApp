namespace StarWarsApp.ExternalService.StarWarsApi.Requests
{
    internal class GetAllFilmsRequest : GetAllRequest<SWApiFilm> { }

    internal class GetFilmsByTitleRequest : GetByNameRequest<SWApiFilm>
    {
        public GetFilmsByTitleRequest(string title) : base(title) { }
    }

    internal class GetFilmByIdRequest : GetByIdRequest<SWApiFilm?>
    {
        public GetFilmByIdRequest(int id) : base(id) { }
    }
}

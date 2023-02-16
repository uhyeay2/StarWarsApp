namespace StarWarsApp.ExternalService.StarWarsApi.Responses
{
    internal class PagedResponse<TResults>
    {
        public int count { get; set; }

        public string? next { get; set; }

        public object? previous { get; set; }

        public TResults[]? results { get; set; }
    }
}

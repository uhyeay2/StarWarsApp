namespace StarWarsApp.ExternalService.StarWarsApi.Responses
{
    public class SWApiPerson
    {
        public string name { get; set; } = null!;

        public string? height { get; set; }

        public string? mass { get; set; }

        public string? hair_color { get; set; }

        public string? skin_color { get; set; }

        public string? eye_color { get; set; }

        public string? birth_year { get; set; }

        public string? gender { get; set; }

        public string? homeworld { get; set; }

        public string[] films { get; set; } = Array.Empty<string>();

        public string[] species { get; set; } = Array.Empty<string>();

        public string[] vehicles { get; set; } = Array.Empty<string>(); 

        public string[] starships { get; set; } = Array.Empty<string>();

        public DateTime created { get; set; }

        public DateTime edited { get; set; }

        public string url { get; set; } = null!;
    }

}

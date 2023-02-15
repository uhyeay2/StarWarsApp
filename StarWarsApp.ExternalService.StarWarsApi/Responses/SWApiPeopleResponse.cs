namespace StarWarsApp.ExternalService.StarWarsApi.Responses
{
    internal class SWApiPeopleResponse
    {
        public int count { get; set; }
        public string? next { get; set; }
        public object? previous { get; set; }
        public SWApiPerson[]? results { get; set; }
    }

    internal class SWApiPerson
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
        public string[]? films { get; set; }
        public string[]? species { get; set; }
        public string[]? vehicles { get; set; }
        public string[]? starships { get; set; }
        public DateTime created { get; set; }
        public DateTime edited { get; set; }
        public string? url { get; set; }

        public Person ParsePerson() => new(name, hair_color, eye_color, gender, homeworld, birth_year);
    }

}

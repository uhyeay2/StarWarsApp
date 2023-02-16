namespace StarWarsApp.ExternalService.StarWarsApi.Responses
{
    public class SWApiFilm
    { 
        public string? title { get; set; }

        public int episode_id { get; set; }
        
        public string? opening_crawl { get; set; }
        
        public string? director { get; set; }
        
        public string? producer { get; set; }
        
        public string? release_date { get; set; }
        
        public string[] characters { get; set; } = Array.Empty<string>();
        
        public string[] planets { get; set; } = Array.Empty<string>();
        
        public string[] starships { get; set; } = Array.Empty<string>();
        
        public string[] vehicles { get; set; } = Array.Empty<string>();
        
        public string[] species { get; set; } = Array.Empty<string>();
        
        public DateTime created { get; set; }
        
        public DateTime edited { get; set; }
        
        public string? url { get; set; }
    }

}

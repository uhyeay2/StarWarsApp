using System.Text.Json;

namespace StarWarsApp.ExternalService.StarWarsApi.Services
{
    abstract public class BaseSWApiService
    {
        protected const string StarWarsApiBaseUrl = "https://swapi.dev/api/";

        protected static HttpClient NewClient() => HttpClientFactory.Create();

        protected static async Task<TOutput?> GetContentOrDefault<TOutput>(string url)
        {
            using var client = NewClient();

            return await DeserializeResponseAsync<TOutput?>(await client.GetAsync(url));
        }

        private static async Task<TOutput?> DeserializeResponseAsync<TOutput>(HttpResponseMessage response)
        {
            if(response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();

                return JsonSerializer.Deserialize<TOutput>(content);
            }

            return default;
        }
    }
}

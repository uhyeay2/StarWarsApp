using System.Text.Json;

namespace StarWarsApp.ExternalService.StarWarsApi.Services
{
    abstract public class BaseSWApiService
    {
        protected const string StarWarsApiBaseUrl = "https://swapi.dev/api/";

        protected static HttpClient NewClient() => HttpClientFactory.Create();

        protected static string SearchParameter(string input) => $"?search={input}";

        protected static async Task<TOutput?> GetContentOrDefaultAsync<TOutput>(string url)
        {
            using var client = NewClient();

            return await DeserializeResponseAsync<TOutput?>(await client.GetAsync(url));
        }

        protected async Task<IEnumerable<TOutput>> GetContentFromAllPagesAsync<TOutput>(string url, List<TOutput>? results = null)
        {
            results ??= new();

            var response = await GetContentOrDefaultAsync<SWApiPagedResponse<TOutput>>(url);

            if (response?.results?.Length > 0)
            {
                foreach (var item in response.results)
                {
                    results.Add(item);
                }
            }

            if (!string.IsNullOrWhiteSpace(response?.next))
            {
                await GetContentFromAllPagesAsync(response.next, results);
            }

            return results;
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

namespace StarWarsApp.ExternalService.StarWarsApi.Services
{
    internal class GetAllPeopleRequest : ExternalServiceRequest<IEnumerable<Person>> { }

    internal class SWApiPeopleService : BaseSWApiService, IExternalService<GetAllPeopleRequest, IEnumerable<Person>>
    {
        protected const string PeopleUrl = StarWarsApiBaseUrl + "people/";

        public async Task<IEnumerable<Person>> GetResponseAsync(GetAllPeopleRequest request) => await GetPeople(PeopleUrl);

        protected async Task<IEnumerable<Person>> GetPeople(string url, List<Person>? people = null)
        {
            people ??= new();

            var response = await GetContentOrDefault<SWApiPeopleResponse>(url);

            if (response?.results?.Length > 0)
            {
                foreach (var swApiPerson in response.results)
                {
                    people.Add(swApiPerson.ParsePerson());
                }
            }

            if (!string.IsNullOrWhiteSpace(response?.next))
            {
                await GetPeople(response.next, people);
            }

            return people;
        }
    }
}

using StarWarsApp.Domain.Models;

namespace StarWarsApp.Services.Interfaces
{
    public interface ISWApiPersonService: ISWApiService
    {
        public IEnumerable<Person> GetAllPeople();

        public Task<IEnumerable<Person>> GetPeopleByNameAsync(string name);

        public Task<Person?> GetPersonByIdAsync(int id);
    }
}

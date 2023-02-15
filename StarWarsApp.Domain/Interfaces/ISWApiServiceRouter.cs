using StarWarsApp.Domain.Models;

namespace StarWarsApp.Domain.Interfaces
{
    public interface ISWApiServiceRouter
    {
        public Task<IEnumerable<Person>> GetAllPeopleAsync();

        public Task<IEnumerable<Person>> GetPeopleByNameAsync(string name);

        public Task<Person?> GetPersonByIdAsync(int id);
    }
}

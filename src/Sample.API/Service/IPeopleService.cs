namespace Sample.API.Service;

public interface IPeopleService
{
    Task<List<PersonEntity>> GetPeopleAsync();
    Task<PersonEntity> GetPersonAsync(int id);
    Task CreatePersonAsync(PersonEntity person);
    Task UpdatePersonAsync(PersonEntity person);
    Task DeletePersonAsync(PersonEntity person);
}
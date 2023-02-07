namespace Sample.API.Service;

public class PeopleService : IPeopleService
{
    private readonly IUnitOfWork unitOfWork;

    public PeopleService(IUnitOfWork unitOfWork)
    {
        this.unitOfWork = unitOfWork;
    }

    public async Task<List<PersonEntity>> GetPeopleAsync()
    {
        var people = await unitOfWork.DatabaseRepository.GetAllAsync();
        return people;
    }

    public async Task<PersonEntity> GetPersonAsync(int id)
    {
        var person = await unitOfWork.DatabaseRepository.GetByIdAsync(id);
        return person;
    }

    public async Task CreatePersonAsync(PersonEntity person)
    {
        await unitOfWork.CommandRepository.CreateAsync(person);
    }

    public async Task UpdatePersonAsync(PersonEntity person)
    {
        await unitOfWork.CommandRepository.UpdateAsync(person);
    }

    public async Task DeletePersonAsync(PersonEntity person)
    {
        await unitOfWork.CommandRepository.DeleteAsync(person);
    }
}
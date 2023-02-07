namespace Sample.API.Handlers;

public class CreatePersonHandler : IRequestHandler<CreatePersonCommand, PersonEntity>
{
    private readonly ILogger<CreatePersonHandler> logger;
    private readonly IPeopleService peopleService;

    public CreatePersonHandler(ILogger<CreatePersonHandler> logger, IPeopleService peopleService)
    {
        this.logger = logger;
        this.peopleService = peopleService;
    }

    public async Task<PersonEntity> Handle(CreatePersonCommand command, CancellationToken cancellationToken)
    {
        var input = new PersonEntity()
        {
            Id = command.Id,
            Cognome = command.Cognome,
            Nome = command.Nome,
            Email = command.Email
        };

        await peopleService.CreatePersonAsync(input);

        return input;
    }
}

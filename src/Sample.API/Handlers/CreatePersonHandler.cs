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
            UserId = command.UserId,
            Cognome = command.Cognome,
            Nome = command.Nome,
            Email = command.Email
        };

        await peopleService.CreatePersonAsync(input);

        var response = new PersonEntity()
        {
            Id = input.Id,
            UserId = input.UserId,
            Cognome = input.Cognome,
            Nome = input.Nome,
            Email = input.Email
        };

        return response;
    }
}

namespace Sample.API.Handlers;

public class CreatePersonHandler : IRequestHandler<CreatePersonCommand, PersonEntity>
{
    private readonly ILogger<CreatePersonHandler> logger;
    private readonly IPeopleService peopleService;
    private readonly IMapper mapper;

    public CreatePersonHandler(ILogger<CreatePersonHandler> logger, IPeopleService peopleService, IMapper mapper)
    {
        this.logger = logger;
        this.peopleService = peopleService;
        this.mapper = mapper;
    }

    public async Task<PersonEntity> Handle(CreatePersonCommand command, CancellationToken cancellationToken)
    {
        var input = mapper.Map<PersonEntity>(command);

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

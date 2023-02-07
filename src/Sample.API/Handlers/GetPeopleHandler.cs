namespace Sample.API.Handlers;

public class GetPeopleHandler : IRequestHandler<GetPeopleListQuery, List<PersonEntity>>
{
    private readonly ILogger<GetPeopleHandler> logger;
    private readonly IPeopleService peopleService;

    public GetPeopleHandler(ILogger<GetPeopleHandler> logger, IPeopleService peopleService)
    {
        this.logger = logger;
        this.peopleService = peopleService;
    }

    public async Task<List<PersonEntity>> Handle(GetPeopleListQuery request, CancellationToken cancellationToken)
    {
        var result = await peopleService.GetPeopleAsync();

        return await Task.FromResult(result);
    }
}
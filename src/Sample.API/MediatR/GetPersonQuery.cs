namespace Sample.API.MediatR;

public class GetPersonQuery : IRequest<PersonEntity>
{
    public Guid Id { get; set; }

    public GetPersonQuery(Guid id)
    {
        Id = id;
    }
}
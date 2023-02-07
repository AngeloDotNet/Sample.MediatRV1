namespace Sample.API.MediatR;

public class GetPersonQuery : IRequest<PersonEntity>
{
    public int Id { get; set; }
    public Guid UserId { get; set; }

    public GetPersonQuery(int id, Guid userId)
    {
        Id = id;
        UserId = userId;
    }
}
using MediatR;
using Sample.API.Entity;

namespace Sample.API.MediatR;

public class GetPeopleListQuery : IRequest<List<PersonEntity>>
{
}
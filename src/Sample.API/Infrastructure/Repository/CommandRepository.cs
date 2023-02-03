using Data.EFCore.CustomV1;
using Microsoft.EntityFrameworkCore;
using Sample.API.Entity;
using Sample.API.Infrastructure.Interfaces;

namespace Sample.API.Infrastructure.Repository;

public class CommandRepository<TContext> : Command<PersonEntity>, ICommandRepository where TContext : DbContext
{
    public CommandRepository(TContext dbContext) : base(dbContext)
    {
    }
}
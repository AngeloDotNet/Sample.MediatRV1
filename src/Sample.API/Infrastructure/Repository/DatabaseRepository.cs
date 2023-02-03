using Data.EFCore.CustomV1;
using Microsoft.EntityFrameworkCore;
using Sample.API.Entity;
using Sample.API.Infrastructure.Interfaces;

namespace Sample.API.Infrastructure.Repository;

public class DatabaseRepository<TContext> : Database<PersonEntity>, IDatabaseRepository where TContext : DbContext
{
    public DatabaseRepository(TContext dbContext) : base(dbContext)
    {
    }
}
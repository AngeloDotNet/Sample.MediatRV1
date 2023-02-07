namespace Sample.API.Infrastructure.Repository;

public class DatabaseRepository<TContext> : Database<PersonEntity>, IDatabaseRepository where TContext : DbContext
{
    public DatabaseRepository(TContext dbContext) : base(dbContext)
    {
    }
}
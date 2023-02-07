namespace Sample.API.Infrastructure.Repository;

public class UnitOfWork<TContext> : IUnitOfWork where TContext : DbContext
{
    private readonly TContext dbContext;
    public IDatabaseRepository DatabaseRepository { get; }
    public ICommandRepository CommandRepository { get; }

    public UnitOfWork(TContext dbContext, IDatabaseRepository databaseRepository, ICommandRepository commandRepository)
    {
        this.dbContext = dbContext;

        DatabaseRepository = databaseRepository;
        CommandRepository = commandRepository;
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    protected virtual void Dispose(bool disposing)
    {
        if (disposing)
        {
            dbContext.Dispose();
        }
    }
}
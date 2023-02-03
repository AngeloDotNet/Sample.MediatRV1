namespace Sample.API.Infrastructure.Interfaces;

public interface IUnitOfWork : IDisposable
{
    IDatabaseRepository DatabaseRepository { get; }
    ICommandRepository CommandRepository { get; }
}
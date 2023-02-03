using Data.EFCore.CustomV1.Interfaces;
using Sample.API.Entity;

namespace Sample.API.Infrastructure.Interfaces;

public interface IDatabaseRepository : IDatabase<PersonEntity>
{
    // Add your custom code here
}
using Arca.Domain.Interfaces;

namespace Arca.Domain.Repositories
{
    public interface IRepositoryBase<TAggregateRoot> : IDisposable where TAggregateRoot : class, IAggregateRoot
    {
        ValueTask AddAsync(TAggregateRoot aggregateRoot);
        void Update(TAggregateRoot aggregateRoot);
        void Delete(TAggregateRoot aggregateRoot);

    }
}

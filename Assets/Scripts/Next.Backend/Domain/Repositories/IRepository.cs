using Next.Backend.Entities;

namespace Next.Backend.Repositories
{
    /// <summary>
    /// Just to mark a class as repository.
    /// </summary>
    public interface IRepository
    {
    }

    public interface IRepository<TEntity> : IReadOnlyRepository<TEntity> where TEntity : class, IEntity
    {
    }

    public interface IRepository<TEntity, TId> : IRepository<TEntity>, IReadOnlyRepository<TEntity, TId>
        where TEntity : class, IEntity<TId>
    {
    }
}
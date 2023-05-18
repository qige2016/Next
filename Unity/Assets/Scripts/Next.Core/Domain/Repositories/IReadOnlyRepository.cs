using System.Collections.Generic;
using Next.Core.Entities;

namespace Next.Core.Repositories
{
    public interface IReadOnlyRepository<TEntity> : IRepository where TEntity : class, IEntity
    {
        /// <summary>
        /// Gets a list of all the entities.
        /// </summary>
        /// <returns>Entity</returns>
        List<TEntity> GetAll();

        /// <summary>
        /// Gets total count of all entities.
        /// </summary>
        /// <returns></returns>
        int GetCount();
    }

    public interface IReadOnlyRepository<TEntity, TId> : IReadOnlyRepository<TEntity>
        where TEntity : class, IEntity<TId>
    {
        /// <summary>
        /// Gets an entity with given primary key.
        /// Throws <see cref="EntityNotFoundException"/> if can not find an entity with given id.
        /// </summary>
        /// <param name="id">Primary key of the entity to get</param>
        /// <returns>Entity</returns>
        TEntity Get(TId id);

        /// <summary>
        /// Gets an entity with given primary key or null if not found.
        /// </summary>
        /// <param name="id">Primary key of the entity to get</param>
        /// <returns>Entity or null</returns>
        TEntity Find(TId id);
    }
}
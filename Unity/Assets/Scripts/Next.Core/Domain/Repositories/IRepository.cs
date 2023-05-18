using System.Collections.Generic;
using Next.Core.Entities;

namespace Next.Core.Repositories
{
    /// <summary>
    /// Just to mark a class as repository.
    /// </summary>
    public interface IRepository
    {
    }

    public interface IRepository<TEntity> : IReadOnlyRepository<TEntity> where TEntity : class, IEntity
    {
        /// <summary>
        /// Inserts a new entity.
        /// </summary>
        /// <param name="entity">Inserted entity</param>
        /// <param name="autoSave"></param>
        /// Set true to automatically save changes to database.
        /// <returns>Entity</returns>
        TEntity Insert(TEntity entity, bool autoSave = false);

        /// <summary>
        /// Inserts multiple new entities.
        /// </summary>
        /// <param name="entities">Entities to be inserted.</param>
        /// <param name="autoSave"></param>
        /// Set true to automatically save changes to database.
        void InsertMany(IEnumerable<TEntity> entities, bool autoSave = false);

        /// <summary>
        /// Updates an existing entity.
        /// </summary>
        /// <param name="entity">Entity</param>
        /// <param name="autoSave"></param>
        /// Set true to automatically save changes to database.
        /// <returns>Entity</returns>
        TEntity Update(TEntity entity, bool autoSave = false);

        /// <summary>
        /// Updates multiple entities.
        /// </summary>
        /// <param name="entities">Entities to be updated.</param>
        /// <param name="autoSave"></param>
        /// Set true to automatically save changes to database.
        void UpdateMany(IEnumerable<TEntity> entities, bool autoSave = false);

        /// <summary>
        /// Deletes an entity.
        /// </summary>
        /// <param name="entity">Entity to be deleted</param>
        /// <param name="autoSave"></param>
        /// Set true to automatically save changes to database.
        void Delete(TEntity entity, bool autoSave = false);

        /// <summary>
        /// Deletes multiple entities.
        /// </summary>
        /// <param name="entities">Entities to be deleted.</param>
        /// <param name="autoSave"></param>
        /// Set true to automatically save changes to database.
        void DeleteMany(IEnumerable<TEntity> entities, bool autoSave = false);
    }

    public interface IRepository<TEntity, TId> : IRepository<TEntity>, IReadOnlyRepository<TEntity, TId>
        where TEntity : class, IEntity<TId>
    {
        /// <summary>
        /// Deletes an entity by primary key.
        /// </summary>
        /// <param name="id">Primary key of the entity</param>
        /// <param name="autoSave"></param>
        /// Set true to automatically save changes to database.
        void Delete(TId id, bool autoSave = false);

        /// <summary>
        /// Deletes multiple entities by primary keys.
        /// </summary>
        /// <param name="ids"></param>
        /// <param name="autoSave"></param>
        void DeleteMany(IEnumerable<TId> ids, bool autoSave = false);
    }
}
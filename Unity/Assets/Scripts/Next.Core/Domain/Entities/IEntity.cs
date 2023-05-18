namespace Next.Core.Entities
{
    /// <summary>
    /// Defines an entity. It's primary key may not be "Id" or it may have a composite primary key.
    /// Use <see cref="IEntity{TId}"/> where possible for better integration to repositories and other structures in the framework.
    /// </summary>
    public interface IEntity
    {
        /// <summary>
        /// Returns an array of ordered keys for this entity.
        /// </summary>
        /// <returns></returns>
        object[] GetIds();
    }

    /// <summary>
    /// Defines an entity with a single primary key with "Id" property.
    /// </summary>
    /// <typeparam name="TId">Type of the primary key of the entity</typeparam>
    public interface IEntity<TId> : IEntity
    {
        /// <summary>
        /// Unique identifier for this entity.
        /// </summary>
        TId Id { get; }
    }
}
namespace Next.Backend.Entities
{
    /// <summary>
    /// Defines an aggregate root. It's primary key may not be "Id" or it may have a composite primary key.
    /// Use <see cref="IAggregateRoot{TId}"/> where possible for better integration to repositories and other structures in the framework.
    /// </summary>
    public interface IAggregateRoot : IEntity
    {
    }

    /// <summary>
    /// Defines an aggregate root with a single primary key with "Id" property.
    /// </summary>
    /// <typeparam name="TId">Type of the primary key of the entity</typeparam>
    public interface IAggregateRoot<TId> : IEntity<TId>, IAggregateRoot
    {
    }
}
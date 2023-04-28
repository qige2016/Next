using System;

namespace Next.Backend.Entities
{
    /// <inheritdoc/>
    [Serializable]
    public abstract class Entity : IEntity
    {
        protected Entity()
        {
        }

        public abstract object[] GetIds();
    }

    /// <inheritdoc cref="IEntity{TId}" />
    [Serializable]
    public abstract class Entity<TId> : Entity, IEntity<TId>
    {
        /// <inheritdoc/>
        [ES3Serializable]
        public virtual TId Id { get; protected set; }

        protected Entity()
        {
        }

        protected Entity(TId id)
        {
            Id = id;
        }

        public override object[] GetIds()
        {
            return new object[] {Id};
        }
    }
}
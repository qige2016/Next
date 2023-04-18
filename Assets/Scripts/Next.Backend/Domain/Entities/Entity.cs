using System;
using System.Collections.Generic;

namespace Next.Backend.Entities
{
    /// <inheritdoc/>
    [Serializable]
    public abstract class Entity : IEntity
    {
        protected Entity()
        {
        }

        public abstract object[] GetKeys();
    }

    /// <inheritdoc cref="IEntity{TKey}" />
    [Serializable]
    public abstract class Entity<TKey> : Entity, IEntity<TKey>
    {
        /// <inheritdoc/>
        public virtual TKey Id { get; protected set; }

        protected Entity()
        {
        }

        protected Entity(TKey id)
        {
            Id = id;
        }

        public override object[] GetKeys()
        {
            return new object[] {Id};
        }
    }
}
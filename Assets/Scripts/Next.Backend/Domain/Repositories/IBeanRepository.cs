﻿using Next.Backend.Entities;

namespace Next.Backend.Repositories
{
    public interface IBeanRepository<TEntity> : IReadOnlyRepository<TEntity> where TEntity : class, IEntity
    {
    }

    public interface IBeanRepository<TEntity, TKey> : IBeanRepository<TEntity> where TEntity : class, IEntity
    {
        public TEntity GetOrDefault(TKey key);

        public TEntity Get(TKey key);
    }
}
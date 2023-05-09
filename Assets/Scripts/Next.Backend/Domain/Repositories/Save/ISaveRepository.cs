﻿using Next.Backend.Entities;
using Next.Backend.Repositories;

namespace Next.Backend.Repositories
{
    public interface ISaveRepository<TEntity> : IRepository<TEntity> where TEntity : class, IEntity
    {
    }

    public interface ISaveRepository<TEntity, TId> : ISaveRepository<TEntity>, IRepository<TEntity, TId>
        where TEntity : class, IEntity<TId>
    {
    }
}
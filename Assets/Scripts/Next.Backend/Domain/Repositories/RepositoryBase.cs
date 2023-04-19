using System.Collections.Generic;
using Next.Backend.Bean;
using Next.Backend.Entities;

namespace Next.Backend.Repositories
{
    public class RepositoryBase<TEntity> : IRepository<TEntity> where TEntity : class, IEntity
    {
        public IEnumerable<TEntity> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public int GetCount()
        {
            throw new System.NotImplementedException();
        }
    }

    public class RepositoryBase<TEntity, TKey> : RepositoryBase<TEntity>, IRepository<TEntity, TKey>
        where TEntity : class, IEntity<TKey>
    {
        public TEntity Get(TKey id)
        {
            throw new System.NotImplementedException();
        }

        public TEntity GetOrDefault(TKey id)
        {
            throw new System.NotImplementedException();
        }
    }
}
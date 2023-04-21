using System.Collections.Generic;
using Bright.Config;
using Next.Backend.Bean;
using Next.Backend.Entities;

namespace Next.Backend.Repositories
{
    public class RepositoryBase<TEntity, TBean, TKey> : IRepository<TEntity>
        where TEntity : class, IEntity, new() where TBean : BeanBase
    {
        private readonly ITable<TBean, TKey> _table;

        public RepositoryBase(ITable<TBean, TKey> table)
        {
            _table = table;
        }

        public List<TEntity> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public int GetCount()
        {
            throw new System.NotImplementedException();
        }
    }
}
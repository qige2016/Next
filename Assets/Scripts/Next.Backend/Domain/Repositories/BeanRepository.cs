using System.Collections.Generic;
using Bright.Config;
using Next.Backend.Bean;
using Next.Backend.Entities;
using Next.Backend.Mapper;

namespace Next.Backend.Repositories
{
    public class BeanRepository<TEntity, TBean, TKey> : IBeanRepository<TEntity, TKey>, IReadOnlyRepository<TEntity>
        where TEntity : class, IEntity, new() where TBean : BeanBase
    {
        private readonly ITable<TBean, TKey> table;
        private readonly IMapper<TEntity, TBean> mapper;

        public BeanRepository(ITable<TBean, TKey> table, IMapper<TEntity, TBean> mapper)
        {
            this.table = table;
            this.mapper = mapper;
        }

        public TEntity GetOrDefault(TKey key) => mapper.Map(table.GetOrDefault(key));

        public TEntity Get(TKey key) => mapper.Map(table.Get(key));

        public List<TEntity> GetAll() => mapper.Map(table.DataList);

        public int GetCount() => table.DataList.Count;
    }
}
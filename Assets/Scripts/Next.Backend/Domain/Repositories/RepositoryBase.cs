using System.Collections.Generic;
using Bright.Config;
using Next.Backend.Bean;
using Next.Backend.Entities;
using Razensoft.Mapper;

namespace Next.Backend.Repositories
{
    public class RepositoryBase<TEntity, TBean, TId> : IRepository<TEntity, TId>
        where TEntity : class, IEntity<TId>, new() where TBean : BeanBase
    {
        private readonly IMapper<TBean, TEntity> _mapper;

        public RepositoryBase(IMapper<TBean, TEntity> mapper)
        {
            _mapper = mapper;
        }

        public List<TEntity> GetAll() => _mapper.MapList(BeanHelper.GetTable<TBean, string>().DataList);

        public int GetCount() => BeanHelper.GetTable<TBean, string>().DataList.Count;

        public TEntity Get(string key) => _mapper.Map(BeanHelper.GetTable<TBean, string>().Get(key));

        public TEntity GetOrDefault(string key)
        {
            var bean = BeanHelper.GetTable<TBean, string>().GetOrDefault(key);
            return bean != null ? _mapper.Map(BeanHelper.GetTable<TBean, string>().GetOrDefault(key)) : null;
        }

        public TEntity Get(TId id)
        {
            throw new System.NotImplementedException();
        }

        public TEntity GetOrDefault(TId id)
        {
            throw new System.NotImplementedException();
        }
    }
}
using Bright.Config;
using Next.Core.Bean;
using Next.Core.Entities;
using Next.Core.Mapper;

namespace Next.Core.Repositories
{
    public class RepositoryBase<TEntity, TBean, TKey, TId> : SaveRepository<TEntity, TId>,
        IBeanRepository<TEntity, TKey> where TEntity : class, IEntity<TId> where TBean : BeanBase
    {
        private readonly BeanRepository<TEntity, TBean, TKey> beanRepository;

        public RepositoryBase(string filePath, ITable<TBean, TKey> table, IMapper<TEntity, TBean> mapper) :
            base(filePath)
        {
            beanRepository = new BeanRepository<TEntity, TBean, TKey>(table, mapper);
        }

        public TEntity GetOrDefault(TKey key) => beanRepository.GetOrDefault(key);

        public TEntity Get(TKey key) => beanRepository.Get(key);
    }
}
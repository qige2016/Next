using Bright.Config;
using Next.Backend.Entities;
using Razensoft.Mapper;

namespace Next.Backend.Mapper
{
    public abstract class EntityMapper<TEntity, TBean> : IMapper<TBean, TEntity>
        where TEntity : class, IEntity where TBean : BeanBase
    {
        public abstract void Map(TBean source, TEntity destination);
    }
}
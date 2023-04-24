using Next.Backend.Entities;

namespace Next.Backend.Repositories
{
    public interface IBeanRepository<TEntity, TKey> where TEntity : class, IEntity, new()
    {
        public TEntity GetOrDefault(TKey key);

        public TEntity Get(TKey key);
    }
}
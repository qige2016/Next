using Next.Backend.Bean;
using Next.Backend.Entities;

namespace Next.Backend.Repositories
{
    public class ItemRepository : RepositoryBase<Item, ItemBean, int>, IItemRepository
    {
        public ItemRepository(ITable<ItemBean, int> table) : base(table)
        {
        }
    }
}
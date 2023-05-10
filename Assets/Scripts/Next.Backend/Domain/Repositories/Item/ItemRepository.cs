using Next.Backend.Bean;
using Next.Backend.Entities;
using Next.Backend.Mapper;

namespace Next.Backend.Repositories
{
    public class ItemRepository : RepositoryBase<Item, ItemBean, string, int>, IItemRepository
    {
        public ItemRepository(string filePath, ITable<ItemBean, string> table, IMapper<Item, ItemBean> mapper) :
            base(filePath, table, mapper)
        {
        }
    }
}
using Next.Backend.Bean;
using Next.Backend.Entities;
using Razensoft.Mapper;

namespace Next.Backend.Repositories
{
    public class ItemRepository : RepositoryBase<Item, ItemBean, int>, IItemRepository
    {
        public ItemRepository(IMapper<ItemBean, Item> mapper) : base(mapper)
        {
        }
    }
}
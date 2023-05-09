using Next.Backend.Entities;

namespace Next.Backend.Repositories
{
    public class ItemRepository : SaveRepository<Item, int>, IItemRepository
    {
        public ItemRepository(string filePath) : base(filePath)
        {
        }
    }
}
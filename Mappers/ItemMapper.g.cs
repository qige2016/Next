using Next.Backend.Bean;
using Next.Backend.Entities;
using Next.Backend.Mapper;

namespace Next.Backend.Mapper
{
    public partial class ItemMapper : IItemMapper
    {
        public Item Map(ItemBean p1)
        {
            return p1 == null ? null : new Item()
            {
                Key = p1.Key,
                Name = p1.Name,
                Desc = p1.Desc,
                Price = p1.Price,
                ExpireTime = p1.ExpireTime,
                BatchUseable = p1.BatchUseable
            };
        }
    }
}
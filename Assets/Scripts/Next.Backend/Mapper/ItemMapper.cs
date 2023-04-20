using Next.Backend.Bean;
using Next.Backend.Entities;
using Razensoft.Mapper;


namespace Next.Backend.Mapper
{
    public class ItemMapper : IMapper<ItemBean, Item>
    {
        public void Map(ItemBean itemBean, Item item)
        {
            item.Key = itemBean.Key;
            item.Name = itemBean.Name;
            item.Desc = itemBean.Desc;
            item.Price = itemBean.Price;
            item.ExpireTime = itemBean.ExpireTime;
            item.BatchUseable = itemBean.BatchUseable;
        }
    }
}
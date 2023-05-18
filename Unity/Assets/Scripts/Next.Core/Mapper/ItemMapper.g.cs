using System.Collections.Generic;
using Next.Core.Bean;
using Next.Core.Entities;
using Next.Core.Mapper;

namespace Next.Core.Mapper
{
    public partial class ItemMapper : IItemMapper
    {
        public Item Map(ItemBean p1)
        {
            return p1 == null ? null : new Item()
            {
                Key = p1.Key,
                Name = p1.Name,
                Desc = p1.Desc
            };
        }
        public List<Item> Map(List<ItemBean> p2)
        {
            if (p2 == null)
            {
                return null;
            }
            List<Item> result = new List<Item>(p2.Count);
            
            int i = 0;
            int len = p2.Count;
            
            while (i < len)
            {
                ItemBean item = p2[i];
                result.Add(item == null ? null : new Item()
                {
                    Key = item.Key,
                    Name = item.Name,
                    Desc = item.Desc
                });
                i++;
            }
            return result;
            
        }
    }
}
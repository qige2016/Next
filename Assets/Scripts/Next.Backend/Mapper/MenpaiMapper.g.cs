using System.Collections.Generic;
using Next.Backend.Bean;
using Next.Backend.Entities;
using Next.Backend.Mapper;

namespace Next.Backend.Mapper
{
    public partial class MenpaiMapper : IMenpaiMapper
    {
        public Menpai Map(MenpaiBean p1)
        {
            return p1 == null ? null : new Menpai()
            {
                Key = p1.Key,
                Name = p1.Name,
                Desc = p1.Desc
            };
        }
        public List<Menpai> Map(List<MenpaiBean> p2)
        {
            if (p2 == null)
            {
                return null;
            }
            List<Menpai> result = new List<Menpai>(p2.Count);
            
            int i = 0;
            int len = p2.Count;
            
            while (i < len)
            {
                MenpaiBean item = p2[i];
                result.Add(item == null ? null : new Menpai()
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
using System.Collections.Generic;
using Next.Core.Bean;
using Next.Core.Entities;
using Next.Core.Mapper;

namespace Next.Core.Mapper
{
    public partial class RoleMapper : IRoleMapper
    {
        public Role Map(RoleBean p1)
        {
            return p1 == null ? null : new Role()
            {
                Key = p1.Key,
                Name = p1.Name,
                Desc = p1.Desc
            };
        }
        public List<Role> Map(List<RoleBean> p2)
        {
            if (p2 == null)
            {
                return null;
            }
            List<Role> result = new List<Role>(p2.Count);
            
            int i = 0;
            int len = p2.Count;
            
            while (i < len)
            {
                RoleBean item = p2[i];
                result.Add(item == null ? null : new Role()
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
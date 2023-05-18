using Next.Core.Bean;
using Next.Core.Entities;
using Next.Core.Mapper;

namespace Next.Core.Repositories
{
    public class RoleRepository : RepositoryBase<Role, RoleBean, string, int>, IRoleRepository
    {
        public RoleRepository(string filePath, ITable<RoleBean, string> table, IMapper<Role, RoleBean> mapper) :
            base(filePath, table, mapper)
        {
        }
    }
}
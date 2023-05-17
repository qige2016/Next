using Next.Backend.Bean;
using Next.Backend.Entities;
using Next.Backend.Mapper;

namespace Next.Backend.Repositories
{
    public class RoleRepository : RepositoryBase<Role, RoleBean, string, int>, IRoleRepository
    {
        public RoleRepository(string filePath, ITable<RoleBean, string> table, IMapper<Role, RoleBean> mapper) :
            base(filePath, table, mapper)
        {
        }
    }
}
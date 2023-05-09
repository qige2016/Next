using Next.Backend.Entities;

namespace Next.Backend.Repositories
{
    public class RoleRepository : SaveRepository<Role, int>, IRoleRepository
    {
        public RoleRepository(string filePath) : base(filePath)
        {
        }
    }
}
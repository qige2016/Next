using Mapster;
using Next.Backend.Bean;
using Next.Backend.Entities;

namespace Next.Backend.Mapper
{
    [Mapper]
    public interface IRoleMapper : IMapper<Role, RoleBean>
    {
    }
}
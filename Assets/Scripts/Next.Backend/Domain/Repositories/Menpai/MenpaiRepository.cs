using Next.Backend.Bean;
using Next.Backend.Entities;
using Next.Backend.Mapper;

namespace Next.Backend.Repositories
{
    public class MenpaiRepository : RepositoryBase<Menpai, MenpaiBean, string, int>, IMenpaiRepository
    {
        protected MenpaiRepository(string filePath, ITable<MenpaiBean, string> table,
            IMapper<Menpai, MenpaiBean> mapper) : base(filePath, table, mapper)
        {
        }
    }
}
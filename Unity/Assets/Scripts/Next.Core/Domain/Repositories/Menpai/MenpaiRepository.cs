using Next.Core.Bean;
using Next.Core.Entities;
using Next.Core.Mapper;

namespace Next.Core.Repositories
{
    public class MenpaiRepository : RepositoryBase<Menpai, MenpaiBean, string, int>, IMenpaiRepository
    {
        public MenpaiRepository(string filePath, ITable<MenpaiBean, string> table,
            IMapper<Menpai, MenpaiBean> mapper) : base(filePath, table, mapper)
        {
        }
    }
}
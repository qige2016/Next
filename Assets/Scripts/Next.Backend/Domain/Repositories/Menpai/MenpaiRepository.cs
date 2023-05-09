using Next.Backend.Entities;

namespace Next.Backend.Repositories
{
    public class MenpaiRepository : SaveRepository<Menpai, int>, IMenpaiRepository
    {
        public MenpaiRepository(string filePath) : base(filePath)
        {
        }
    }
}
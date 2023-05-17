using Mapster;
using Next.Backend.Bean;
using Next.Backend.Entities;

namespace Next.Backend.Mapper
{
    [Mapper]
    public interface IItemMapper : IMapper<Item, ItemBean>
    {
    }
}
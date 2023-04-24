using System.Collections.Generic;

namespace Next.Backend.Mapper
{
    public interface IMapper<TDestination, TSource>
    {
        TDestination Map(TSource source);

        List<TDestination> Map(List<TSource> source);
    }
}
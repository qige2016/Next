using System.Collections.Generic;

namespace Next.Core.Mapper
{
    public interface IMapper<TDestination>
    {
        TDestination Map(object source);
        
        List<TDestination> Map(List<object> source);
    }
    
    public interface IMapper<TDestination, TSource>
    {
        TDestination Map(TSource source);

        List<TDestination> Map(List<TSource> source);
    }
}
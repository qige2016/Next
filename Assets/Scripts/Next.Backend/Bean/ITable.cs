using Bright.Config;

namespace Next.Backend.Bean
{
    public interface ITable
    {
    }

    public interface ITable<in TKey, out TBean> : ITable where TBean : BeanBase
    {
        TBean GetOrDefault(TKey key);
        TBean Get(TKey key);
        TBean this[TKey key] { get; }
    }
}
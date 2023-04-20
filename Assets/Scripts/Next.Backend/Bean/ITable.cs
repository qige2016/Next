using Bright.Config;

namespace Next.Backend.Bean
{
    public interface ITable
    {
    }

    public interface ITable<TBean> : ITable where TBean : BeanBase
    {
    }

    public interface ITable<TBean, TKey> : ITable<TBean> where TBean : BeanBase
    {
        TBean GetOrDefault(TKey key);
        TBean Get(TKey key);
        TBean this[TKey key] { get; }
    }
}
using System.Collections.Generic;
using Bright.Config;

namespace Next.Core.Bean
{
    public interface ITable
    {
    }

    public interface ITable<TBean> : ITable where TBean : BeanBase
    {
    }

    public interface ITable<TBean, TKey> : ITable<TBean> where TBean : BeanBase
    {
        List<TBean> DataList { get; }
        TBean GetOrDefault(TKey key);
        TBean Get(TKey key);
    }
}
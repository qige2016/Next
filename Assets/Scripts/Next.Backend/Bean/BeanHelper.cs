using System.IO;
using Bright.Config;
using SimpleJSON;

namespace Next.Backend.Bean
{
    public static class BeanHelper
    {
        public static Tables GetTables()
        {
            return new Tables(file =>
                JSON.Parse(File.ReadAllText($"Assets/StreamingAssets/GenerateDatas/Json/{file}.json",
                    System.Text.Encoding.UTF8)));
        }

        public static ITable<TBean, TKey> GetTable<TBean, TKey>() where TBean : BeanBase
        {
            return GetTables().GetTable<TBean, TKey>();
        }

        //设定key为string类型
        public static TBean GetBean<TBean, TKey>(TKey key) where TBean : BeanBase
        {
            return GetTable<TBean, TKey>().Get(key);
        }
    }
}
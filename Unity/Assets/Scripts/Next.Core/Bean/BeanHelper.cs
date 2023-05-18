using System.IO;
using Bright.Config;
using SimpleJSON;

namespace Next.Core.Bean
{
    public static class BeanHelper
    {
        public static ITable<TBean, TKey> GetTable<TBean, TKey>() where TBean : BeanBase
        {
            return new Tables().GetTable<TBean, TKey>(file =>
                JSON.Parse(File.ReadAllText($"Assets/StreamingAssets/GenerateDatas/Json/{file}.json",
                    System.Text.Encoding.UTF8)));
        }

        public static TBean GetBean<TBean, TKey>(TKey key) where TBean : BeanBase
        {
            return GetTable<TBean, TKey>().Get(key);
        }
    }
}
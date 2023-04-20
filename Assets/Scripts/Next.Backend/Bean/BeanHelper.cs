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

        public static ITable<TBean, string> GetTable<TBean>() where TBean : BeanBase
        {
            return GetTables().GetTable<TBean, string>();
        }

        public static TBean GetBean<TBean>(string key) where TBean : BeanBase
        {
            return GetTable<TBean>().Get(key);
        }
    }
}
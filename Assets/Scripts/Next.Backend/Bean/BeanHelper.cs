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
    }
}
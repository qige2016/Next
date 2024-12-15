using Cysharp.Threading.Tasks;

namespace Next.Fontend
{
    public class DataProvider : IInitializableService
    {
        public bool IsInitialized { get; set; }
        public async UniTask Initialize()
        {
            IsInitialized = true;
        }
    }
}
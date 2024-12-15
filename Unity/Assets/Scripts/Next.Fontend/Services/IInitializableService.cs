using Cysharp.Threading.Tasks;

namespace Next.Fontend
{
    public interface IInitializableService
    {
        bool IsInitialized { get; set; }
        UniTask Initialize();
    }
}
using Cysharp.Threading.Tasks;
using System.Threading;
using VContainer.Unity;

namespace Next.Fontend
{
    public class BootstrapSceneEntryPoint : IInitializable, IAsyncStartable 
    {
        public void Initialize()
        {
        }


        public async UniTask StartAsync(CancellationToken cancellation)
        {
        }
    }
}

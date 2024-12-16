using System.Collections.Generic;
using System.Threading;
using Cysharp.Threading.Tasks;
using VContainer;
using VContainer.Unity;

namespace Next.Fontend
{
    public class Boot : IAsyncStartable
    {
        private AppLifetimeScope _appLifetimeScope;
        private IReadOnlyList<IInitializableService> _services;
        private ISceneService _sceneService;

        [Inject]
        public void Construct(AppLifetimeScope appLifetimeScope, IReadOnlyList<IInitializableService> allServices,
            ISceneService sceneService)
        {
            _appLifetimeScope = appLifetimeScope;
            _services = allServices;
            _sceneService = sceneService;
        }

        public async UniTask StartAsync(CancellationToken cancellation)
        {
            
        }
    }
}
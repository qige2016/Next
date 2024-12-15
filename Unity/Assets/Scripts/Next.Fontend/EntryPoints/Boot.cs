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
        private ISceneLoader _sceneLoader;

        [Inject]
        public void Construct(AppLifetimeScope appLifetimeScope, IReadOnlyList<IInitializableService> allServices,
            ISceneLoader sceneLoader)
        {
            _appLifetimeScope = appLifetimeScope;
            _services = allServices;
            _sceneLoader = sceneLoader;
        }

        public async UniTask StartAsync(CancellationToken cancellation)
        {
            _sceneLoader.LoadScene(GameConstants.Scenes.GamePath);
        }
    }
}
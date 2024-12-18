using System.Collections.Generic;
using System.Threading;
using Cysharp.Threading.Tasks;
using Next.Core.Repositories;
using VContainer;
using VContainer.Unity;

namespace Next.Fontend
{
    public class Boot : IAsyncStartable
    {
        private AppLifetimeScope _appLifetimeScope;
        private ISceneService _sceneService;
        private MenpaiRepository _menpaiRepository;

        [Inject]
        public void Construct(AppLifetimeScope appLifetimeScope, ISceneService sceneService, MenpaiRepository menpaiRepository)
        {
            _appLifetimeScope = appLifetimeScope;
            _sceneService = sceneService;
            _menpaiRepository = menpaiRepository;
        }

        public async UniTask StartAsync(CancellationToken cancellation)
        {
           var entity = _menpaiRepository.Get("门派甲");
        }
    }
}
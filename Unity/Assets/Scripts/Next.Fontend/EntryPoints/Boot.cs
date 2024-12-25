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
        private IReadOnlyList<IInitializableService> _services;
        private MenpaiRepository _menpaiRepository;
        private RoleRepository _roleRepository;

        [Inject]
        public void Construct(AppLifetimeScope appLifetimeScope, ISceneService sceneService, IReadOnlyList<IInitializableService> services, MenpaiRepository menpaiRepository, RoleRepository roleRepository)
        {
            _appLifetimeScope = appLifetimeScope;
            _sceneService = sceneService;
            _services = services;
            _menpaiRepository = menpaiRepository;
            _roleRepository = roleRepository;
        }

        public async UniTask StartAsync(CancellationToken cancellation)
        {
            InitializeServices(_services);
        }

        private void InitializeServices(IReadOnlyList<IInitializableService> services)
        {
            foreach (IInitializableService service in services)
            {
                service.Initialize();
            }
        }
    }
}
using VContainer;
using VContainer.Unity;

namespace Next.Fontend
{
    public class AppLifetimeScope : LifetimeScope
    {
        protected override void Configure(IContainerBuilder builder)
        {
            builder.Register<SceneService>(Lifetime.Singleton).AsImplementedInterfaces();
            builder.RegisterEntryPoint<Boot>();
        }
    }
}

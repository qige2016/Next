using Next.Core.Bean;
using Next.Core.Mapper;
using Next.Core.Repositories;
using VContainer;
using VContainer.Unity;

namespace Next.Fontend
{
    public class AppLifetimeScope : LifetimeScope
    {
        protected override void Configure(IContainerBuilder builder)
        {
            builder.Register<SceneService>(Lifetime.Singleton).AsImplementedInterfaces();
            builder.Register<MenpaiRepository>(Lifetime.Singleton).AsImplementedInterfaces().AsSelf()
                .WithParameter("filePath", "menpai_repository_tests").WithParameter("table", BeanHelper.GetTable<MenpaiBean, string>()).WithParameter("mapper", new MenpaiMapper());
            builder.RegisterEntryPoint<Boot>();
        }
    }
}

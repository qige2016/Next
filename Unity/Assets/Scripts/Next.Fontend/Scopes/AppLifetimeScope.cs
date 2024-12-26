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
            RegisterEntryPoints(builder);
            RegisterServices(builder);
        }

        private void RegisterEntryPoints(IContainerBuilder builder)
        {
        }

        private void RegisterServices(IContainerBuilder builder)
        {
            builder.Register<MenpaiRepository>(Lifetime.Singleton).AsSelf()
                .WithParameter("filePath", "PERSISTENT_DATA").WithParameter("table", BeanHelper.GetTable<MenpaiBean, string>()).WithParameter("mapper", new MenpaiMapper());
            builder.Register<RoleRepository>(Lifetime.Singleton).AsSelf()
                .WithParameter("filePath", "PERSISTENT_DATA").WithParameter("table", BeanHelper.GetTable<RoleBean, string>()).WithParameter("mapper", new RoleMapper());
        }
    }
}

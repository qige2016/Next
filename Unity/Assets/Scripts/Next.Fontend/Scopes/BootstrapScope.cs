using VContainer;
using VContainer.Unity;

namespace Next.Fontend
{
	public class BootstrapScope : LifetimeScope
	{
		protected override void Configure(IContainerBuilder builder)
		{
            builder.RegisterEntryPoint<BootstrapSceneEntryPoint>().AsSelf();
        }
	}
}

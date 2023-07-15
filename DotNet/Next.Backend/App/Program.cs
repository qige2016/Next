using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Next.Backend.Extensions;

namespace Next.Backend.App
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = new HostBuilder()
                .ConfigureAppConfiguration((_, config) =>
                {
                    config.AddEnvironmentVariables();
                    config.SetBasePath(EnvironmentExtension.GetCurrentEnvironementDirectory());
                    config.AddYamlFile("config/server.yml", optional: false, reloadOnChange: true);
                }).ConfigureServices((hostContext, services) =>
                {
                    services.AddOptions();
                    services.Configure<ServerOptions>(hostContext.Configuration.GetSection("server"));
                    services.Configure<CoreCacheServerOptions>(hostContext.Configuration.GetSection("core-cache-server"));

                    services.AddAccountPersistance(hostContext.Configuration.GetSection("account-database")
                        .Get<DatabaseOptions>());
                    services.AddGamePersistance(hostContext.Configuration.GetSection("game-database")
                        .Get<DatabaseOptions>());
                    
                    services.AddSingleton<IClusterCache, CoreCacheServer>(serviceProvider => serviceProvider.GetRequiredService<CoreCacheServer>());
                })
                .ConfigureLogging(builder =>
                {
                    builder.AddConsole();
                    builder.AddLoggingFilters();
                })
        }
    }
}
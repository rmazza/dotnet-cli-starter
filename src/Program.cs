using System;
using System.IO;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace CLI
{
    class Program
    {
        public static ILogger _logger;
        public static IConfigurationRoot _config;

        static void Main(string[] args)
        {
            _config = BuildConfig(new ConfigurationBuilder());

            var services = new ServiceCollection();
            ConfigureServices(services);
            
            ServiceProvider serviceProvider = services.BuildServiceProvider();
            
            _logger = serviceProvider.GetService<ILogger>();
            CommandRunner app = serviceProvider.GetService<CommandRunner>();

            try
            {
                app.Start(args);
            }
            catch (Exception ex)
            {
                app.HandleException(ex);
            }
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            services.AddLogging(configure => configure.AddConsole());
            services.AddTransient<CommandRunner>();
            services.AddSingleton<IConfiguration>(_config);
        }

        static IConfigurationRoot BuildConfig(IConfigurationBuilder builder)
        {
            var environment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");

            return builder.SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddJsonFile($"appsettings.{environment}.json", optional: true)
                .AddEnvironmentVariables().Build();
        }
    }
}

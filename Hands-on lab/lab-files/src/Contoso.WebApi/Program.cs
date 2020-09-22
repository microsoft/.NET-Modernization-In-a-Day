using Contoso.Azure.KeyVault;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.ApplicationInsights;

namespace Contoso.WebApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args)
        {
            var instrumentationkey = string.Empty;
            return WebHost.CreateDefaultBuilder(args)
            .ConfigureAppConfiguration((context, config) =>
            {
                var buildConfig = config.Build();
                config.AddEnvironmentVariables();
                instrumentationkey = buildConfig["APPINSIGHTS_INSTRUMENTATIONKEY"];
                //challange implement keyvault using the callback functions to skp using clientid and clientsecret.
                config.AddAzureKeyVault(KeyVaultConfig.GetKeyVaultEndpoint(buildConfig["KeyVaultName"]),
                    buildConfig["KeyVaultClientId"],
                    buildConfig["KeyVaultClientSecret"]);
            })
            .ConfigureLogging(options =>
            {
                options.ClearProviders();
                options.AddConsole();
                options.AddApplicationInsights(instrumentationkey, options => { options.TrackExceptionsAsExceptionTelemetry = true; });
                options.AddFilter<ApplicationInsightsLoggerProvider>("", LogLevel.Trace);
            })
            .UseStartup<Startup>();
        }
        
    }
}
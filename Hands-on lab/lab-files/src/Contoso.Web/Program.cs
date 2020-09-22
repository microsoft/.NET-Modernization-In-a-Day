using Contoso.Azure.KeyVault;
using Contoso.Web.Configuration;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using System.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.ApplicationInsights;

namespace Contoso.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args)
        {
            string instrumentationKey = string.Empty;
            var web=  WebHost.CreateDefaultBuilder(args)
                .ConfigureAppConfiguration((context, config) =>
                {
                    var buildConfig = config.Build();
                    config.AddEnvironmentVariables();
                    instrumentationKey = buildConfig["APPINSIGHTS_INSTRUMENTATIONKEY"];
                    if (string.IsNullOrEmpty(buildConfig["KeyVaultName"]) || string.IsNullOrEmpty(buildConfig["KeyVaultClientId"]) || string.IsNullOrEmpty(buildConfig["KeyVaultClientSecret"]))
                        throw new ConfigurationErrorsException("one or all of the configuration settings for Azure key vault are missing");
                    //challange rewrite the implementation of the keyvault to use the callback funciton instead of using the client id and secret.
                    config.AddAzureKeyVault(KeyVaultConfig.GetKeyVaultEndpoint(buildConfig["KeyVaultName"]), buildConfig["KeyVaultClientId"], buildConfig["KeyVaultClientSecret"]);
                })
                .ConfigureLogging(opt =>
                {
                    opt.AddConsole();                    
                    if (!string.IsNullOrEmpty(instrumentationKey))
                    {
                        opt.AddApplicationInsights(instrumentationKey , opt=> { opt.TrackExceptionsAsExceptionTelemetry = true; });
                    }
                    opt.AddFilter<ApplicationInsightsLoggerProvider>("", LogLevel.Trace);
                })
                .UseStartup<Startup>();
            return web;
        }
    }
}

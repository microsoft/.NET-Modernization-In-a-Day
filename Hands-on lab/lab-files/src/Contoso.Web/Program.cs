using Contoso.Azure.KeyVault;
using Contoso.Web.Configuration;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using System.Configuration;

namespace Contoso.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .ConfigureAppConfiguration((context, config) =>
                {
                var buildConfig = config.Build();
                    config.AddEnvironmentVariables();
                    if (string.IsNullOrEmpty(buildConfig["KeyVaultName"]) || string.IsNullOrEmpty(buildConfig["KeyVaultClientId"]) || string.IsNullOrEmpty(buildConfig["KeyVaultClientSecret"]))
                        throw new ConfigurationErrorsException("one or all of the configuration settings for Azure key vault are missing");
                    config.AddAzureKeyVault(KeyVaultConfig.GetKeyVaultEndpoint(buildConfig["KeyVaultName"]), buildConfig["KeyVaultClientId"], buildConfig["KeyVaultClientSecret"]);                    
                })
                .UseStartup<Startup>();
    }
}

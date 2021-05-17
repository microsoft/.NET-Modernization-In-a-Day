using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using System;
using System.Net.Http;
/*
 * this class is used to introduce DI in serverless functions
 * the challange here is to make your own implementaion of keyvault
 */
[assembly: FunctionsStartup(typeof(Contoso.FunctionApp.Startup))]
namespace Contoso.FunctionApp
{

    public class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            var serviceProvider = builder?.Services.BuildServiceProvider();
            builder.Services.AddHttpClient();
            builder.Services.AddLogging();            
            builder.Services.AddApplicationInsightsTelemetry(options =>
            {
                var instkey = Environment.GetEnvironmentVariable("APPINSIGHTS_INSTRUMENTATIONKEY") ?? string.Empty;
                if (string.IsNullOrEmpty(instkey))
                {                    
                    throw new ArgumentNullException("Unable to find a instrumentationkey for Applicaiton Insights ");
                }
                else
                {
                    options.InstrumentationKey = instkey;                    
                }
                
            });
        }
    }
}

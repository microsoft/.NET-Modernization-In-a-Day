using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using System;
using System.Net.Http;

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
                var instkey = Environment.GetEnvironmentVariable("InstrumentationKey") ?? string.Empty;
                if (string.IsNullOrEmpty(instkey))
                {                    
                    throw new ArgumentNullException("Unable to find a instrumentationkey for Applicaiton Insights ");
                }
                else
                {
                    options.InstrumentationKey = instkey;
                    Console.WriteLine($"instrumentationkey found ");
                }
                
            });
        }
    }
}

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Contoso.FunctionApp
{
    public class PolicyDocsFunction
    {

        private readonly  IHttpClientFactory client;
        private readonly ILogger logger;
        public PolicyDocsFunction(IHttpClientFactory httpclient, ILogger<PolicyDocsFunction> log)
        {
            client = httpclient;
            logger = log;
        }
        // ******************************************
        // TODO #3: Insert code in this block to parameterize the function by defining the Route
        [FunctionName("PolicyDocs")]
        public  async Task<IActionResult> Run(
                [HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = "{policyholder}/{policynumber}")] HttpRequest req , string policyholder , string  policynumber )
        // ******************************************
        {
        
            logger.LogTrace("PolicyDocs Function recieved a request for document '{policyholder}-{policynumber}.pdf'." ,policyholder,policynumber);
            var fileBytes = await GetDocumentFromStorage(policyholder, policynumber);
            return fileBytes.Length > 0
                ? (ActionResult)new FileContentResult(fileBytes, "application/pdf")
                : new NotFoundObjectResult("No policy document was found for the specified policy holder and number");
        }

        private  async Task<byte[]> GetDocumentFromStorage(string policyHolder, string policyNumber)
        {
            // ******************************************
            // TODO #4: Insert code in this block to enable the Function App to retrieve configuration values from Appplication Settings.
            var containerUri = Environment.GetEnvironmentVariable("containerUri");
            var sasToken = Environment.GetEnvironmentVariable("sasToken");
            // ******************************************
            var cli = client.CreateClient();
            var uri = $"{containerUri}/{policyHolder}-{policyNumber}.pdf{sasToken}";            
            using (var request = new HttpRequestMessage())
               {
                  request.Method = HttpMethod.Get;
                logger.LogTrace("starting a request to {uri}",uri);
                  request.RequestUri = new Uri(uri);
                  var response = await cli.SendAsync(request).ConfigureAwait(false);
                  if (response.IsSuccessStatusCode)
                    {
                        return await response.Content.ReadAsByteArrayAsync();
                    }
                    else
                    {
                        return new byte[] { };
                    }
                }
            
        }
    }
}

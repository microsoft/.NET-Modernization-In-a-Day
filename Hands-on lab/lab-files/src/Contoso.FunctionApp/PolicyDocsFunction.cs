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
    public static class PolicyDocsFunction
    {
        // ******************************************
        // TODO #3: Insert code in this block to parameterize the function by defining the Route
        [FunctionName("PolicyDocs")]
        public static async Task<IActionResult> Run(
                [HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)] HttpRequest req, ILogger log)
        // ******************************************
        {
            log.LogInformation($"PolicyDocs Function recieved a request for document '{policyHolder}-{policyNumber}.pdf'.");

            var fileBytes = await GetDocumentFromStorage(policyHolder, policyNumber);

            return fileBytes.Length > 0
                ? (ActionResult)new FileContentResult(fileBytes, "application/pdf")
                : new NotFoundObjectResult("No policy document was found for the specified policy holder and number");
        }

        private static async Task<byte[]> GetDocumentFromStorage(string policyHolder, string policyNumber)
        {
            // ******************************************
            // TODO #4: Insert code in this block to enable the Function App to retrieve configuration values from Appplication Settings.
            var containerUri = // Retrieve the PolicyStorageUrl Environment variable 
            var sasToken = // Retrieve the PolicyStorageSas Environment variable 
            // ******************************************

            var uri = $"{containerUri}/{policyHolder}-{policyNumber}.pdf{sasToken}";

            using (var client = new HttpClient())
            {
                using (var request = new HttpRequestMessage())
                {
                    request.Method = HttpMethod.Get;
                    request.RequestUri = new Uri(uri);

                    var response = await client.SendAsync(request).ConfigureAwait(false);

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
}

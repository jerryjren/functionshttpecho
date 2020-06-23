using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;

namespace JR.LongRunningApp
{
    public class LongRunningApp
    {
        [FunctionName(nameof(LongRunningApp))]
        public static async Task<IActionResult> Run([HttpTrigger(AuthorizationLevel.Function, "get", Route = null)]
            HttpRequest req,
            ILogger log)
        {
            // Simulate long running operation
            await Task.Delay(5000);

            // Simulate different situation of 80% chance return 202, and 20% chance return 200
            var random = new Random();
            var number = random.Next(10);

            if (number < 2)
            {
                return new OkObjectResult("Done");
            }
            
            new HttpResponseMessage(HttpStatusCode.Accepted)
            {
                Content = null,
                Headers =
                {
                    
                }
            };
            
            
            return new AcceptedResult();
        }
    }
}
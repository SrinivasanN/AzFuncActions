using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace My.Function
{
    public class HttpTriggerEx
    {
        private readonly ILogger<HttpTriggerEx> _logger;

        public HttpTriggerEx(ILogger<HttpTriggerEx> logger)
        {
            _logger = logger;
        }

        [Function("HttpTriggerEx")]
        public IActionResult Run([HttpTrigger(AuthorizationLevel.Anonymous, "get", "post")] HttpRequest req)
        {
            _logger.LogInformation("C# HTTP trigger function processed a request.");
            return new OkObjectResult("Welcome to Azure Functions!");
        }
    }
}

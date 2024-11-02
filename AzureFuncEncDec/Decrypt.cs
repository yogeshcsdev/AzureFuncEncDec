using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace AzureFuncEncDec
{
    public class Decrypt
    {
        private readonly ILogger<Decrypt> _logger;

        public Decrypt(ILogger<Decrypt> logger)
        {
            _logger = logger;
        }

        [Function("Decrypt")]
        public IActionResult Run([HttpTrigger(AuthorizationLevel.Function, "post")] HttpRequest req)
        {
            _logger.LogInformation("C# HTTP trigger function processed a request.");
            return new OkObjectResult("Welcome to Azure Functions!");
        }
    }
}

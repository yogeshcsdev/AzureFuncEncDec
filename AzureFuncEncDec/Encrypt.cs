using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace AzureFuncEncDec
{
    public class Encrypt
    {
        private readonly ILogger<Encrypt> _logger;

        public Encrypt(ILogger<Encrypt> logger)
        {
            _logger = logger;
        }

        [Function("Encrypt")]
        public IActionResult Run([HttpTrigger(AuthorizationLevel.Function, "post")] HttpRequest req)
        {
            _logger.LogInformation("C# HTTP trigger function processed a request.");
            return new OkObjectResult("Welcome to Azure Functions!");
        }
    }
}

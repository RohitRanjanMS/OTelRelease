using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace WithoutOtel
{
    public class FunctionWithoutOtel
    {
        private readonly ILogger<FunctionWithoutOtel> _logger;

        public FunctionWithoutOtel(ILogger<FunctionWithoutOtel> logger)
        {
            _logger = logger;
        }

        [Function("FunctionWithoutOtel")]
        public IActionResult Run([HttpTrigger(AuthorizationLevel.Anonymous, "get", "post")] HttpRequest req)
        {
            _logger.LogInformation("C# HTTP trigger function processed a request. - " + DateTime.Now.ToString());
            return new OkObjectResult("Welcome to Azure Functions! - " + DateTime.Now.ToString());
        }
    }
}

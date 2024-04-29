using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace WithOtel
{
    public class FunctionWithOtel
    {
        private readonly ILogger<FunctionWithOtel> _logger;

        public FunctionWithOtel(ILogger<FunctionWithOtel> logger)
        {
            _logger = logger;
        }

        [Function("FunctionWithOtel")]
        public IActionResult Run([HttpTrigger(AuthorizationLevel.Anonymous, "get", "post")] HttpRequest req)
        {
            _logger.LogInformation("C# HTTP trigger function processed a request. - " + DateTime.Now.ToString());
            return new OkObjectResult("Welcome to Azure Functions WithOtel! - " + DateTime.Now.ToString());
        }
    }
}

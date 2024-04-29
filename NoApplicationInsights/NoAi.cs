using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace NoApplicationInsights
{
    public class NoAi
    {
        private readonly ILogger<NoAi> _logger;

        public NoAi(ILogger<NoAi> logger)
        {
            _logger = logger;
        }

        [Function("NoAi")]
        public IActionResult Run([HttpTrigger(AuthorizationLevel.Anonymous, "get", "post")] HttpRequest req)
        {
            _logger.LogInformation("C# HTTP trigger function processed a request. - " + DateTime.Now.ToString());
            return new OkObjectResult("Welcome to Azure Functions! - " + DateTime.Now.ToString());
        }
    }
}

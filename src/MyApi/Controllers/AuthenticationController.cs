using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MyApi.Controllers
{
    [ApiController]
    [Route("auth")]
    public class AuthenticationController : ControllerBase
    {
        readonly ILogger<AuthenticationController> _logger;
        public AuthenticationController(ILogger<AuthenticationController> logger)
        {
            _logger = logger;
        }
        
        [Route("publish/check")]
        [HttpGet]
        public IActionResult CanPublishVideoStreaming(string name, string token)
        {
            if (name == "test" && token == "superpublishsecretkey")
            {
                return NoContent();
            }
            
            return Unauthorized();
        }

        [Route("watch/check")]
        [HttpGet]
        public IActionResult CanWatchVideoStreaming(string name, string token)
        {
            if (name == "test" && token == "superwatchsecretkey")
            {
                return NoContent();
            }
            return Unauthorized();
        }
    }
}
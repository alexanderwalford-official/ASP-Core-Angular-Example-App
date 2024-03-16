using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace Training_App.Controllers
{
    [Route("[controller]")]
    public class BasicController : Controller
    {
        private readonly ILogger<BasicController> _logger;

        public BasicController(ILogger<BasicController> logger)
        {
            _logger = logger;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            _logger.LogInformation("GET");
            return Ok("Index API page for basic controller.");
        }

        [HttpGet("names")]
        public IEnumerable<string> GetNames()
        {
            _logger.LogInformation("GET NAMES");
            string[] names = { "Steve", "Josh", "Jen", "Mark", "Ben", "Harry", "Natalie" };
            return names;
        }

        [HttpGet("ages")]
        public IEnumerable<int> GetAges()
        {
            _logger.LogInformation("GET AGES");
            int[] ages = { 23, 54, 65, 24, 56, 18, 62 };
            return ages;
        }

    }
}

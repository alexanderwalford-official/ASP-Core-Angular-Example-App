using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace Training_App.Controllers
{
    [Route("[controller]")]
    public class BasicController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            Console.WriteLine("GET");
            return Ok("Index page!");
        }

        [HttpGet("name")]
        public string Name()
        {
            return "Jeff";
        }
    }
}

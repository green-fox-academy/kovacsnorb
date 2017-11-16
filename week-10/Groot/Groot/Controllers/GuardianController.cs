using Groot.Services;
using Microsoft.AspNetCore.Mvc;

namespace Groot.Controllers
{
    public class GuardianController
    {
        [HttpGet]
        [Route("groot")]
        public IActionResult Index([FromQuery] string someMessage)
        {
            var myService = new GuardianService();
            return myService.GuardianTranslator(someMessage);
        }

        [HttpGet]
        [Route("yondu")]
        public IActionResult Arrow([FromQuery] double distance, double time)
        {
            var myService = new ArrowService();
            return myService.ArrowCalculator(distance, time);
        }
    }
}

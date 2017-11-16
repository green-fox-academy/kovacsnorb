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
            var myService = new GuardianServices();
            return myService.GuardianTranslator(someMessage); ;
        }
    }
}

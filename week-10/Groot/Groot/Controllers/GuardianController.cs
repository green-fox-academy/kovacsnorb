using Groot.Models;
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
            return new GuardianService().GuardianTranslator(someMessage);
        }

        [HttpGet]
        [Route("yondu")]
        public IActionResult Arrow([FromQuery] double distance, double time)
        {
            return new ArrowService().ArrowCalculator(distance, time);
        }

        [HttpGet]
        [Route("rocket")]
        public IActionResult LoadShip()
        {
            return new CargoService().ShowActualCargo();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Groot.Models;

namespace Groot.Controllers
{
    public class GuardianController : Controller
    {
        [HttpGet]
        [Route("groot")]
        public IActionResult Index([FromQuery] string someMessage)
        {
            if (someMessage is null)
            {
                return Json(new Error());
            }
            else
            {
                return Json(new TranslatedGroot(someMessage));
            }
        }
    }
}

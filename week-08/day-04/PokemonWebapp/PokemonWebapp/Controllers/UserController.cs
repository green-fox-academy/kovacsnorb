using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PokemonWebapp.Controllers
{
    [Route("/user")]
    public class UserController : Controller
    {
        [HttpPost]
        public IActionResult LoginHandler()
        {
            return View();
        }
    }
}

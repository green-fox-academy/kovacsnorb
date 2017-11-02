using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PokemonWebapp.Models;

namespace PokemonWebapp.Controllers
{
    [Route("/user")]
    public class UserController : Controller
    {
        [HttpPost]
        public IActionResult LoginHandler(User user)
        {
            return LocalRedirect("/user/" + user.Name);
        }

        [HttpGet]
        [Route("/user/{user.Name}")]
        public IActionResult Profile(string userName)
        {
            return View();
        }
    }
}

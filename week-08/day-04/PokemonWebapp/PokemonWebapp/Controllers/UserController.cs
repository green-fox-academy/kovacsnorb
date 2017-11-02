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
        User user;

        public UserController(User user)
        {
            this.user = user;
        }

        [HttpPost]
        public IActionResult LoginHandler(User userFromForm)
        {
            user.Name = userFromForm.Name;
            user.Pokemons.Add(new Pokemon() { Id = 1, Level = 2, Type = PokemonType.Froakie });
            return LocalRedirect("/user/" + user.Name);
        }

        [HttpGet]
        [Route("/user/{0}")]
        public IActionResult Profile()
        {
            return View(user);
        }
    }
}

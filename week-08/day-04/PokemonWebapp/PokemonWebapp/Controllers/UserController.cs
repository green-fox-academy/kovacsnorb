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
        Random random = new Random();
        User user;

        public UserController(User user)
        {
            this.user = user;
        }

        [HttpPost]
        public IActionResult LoginHandler(User userFromForm)
        {
            user.Name = userFromForm.Name;
            user.Pokemons.Add(new Pokemon() { Id = user.Pokemons.Count + 1, Level = random.Next(1,6), Type = (PokemonType)random.Next(1, 22) });
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

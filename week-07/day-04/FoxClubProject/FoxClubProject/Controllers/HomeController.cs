using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FoxClubProject.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FoxClubProject.Controllers
{
    public class HomeController : Controller
    {
        private Fox fox;

        public HomeController(Fox fox)
        {
            this.fox = fox;
        }

        [HttpGet]
        [Route("")]
        public IActionResult Index(Fox fox)
        {
            this.fox = fox;
            fox.Name = "Fox Mulder";
            fox.Food = FoodType.apple;
            fox.Drink = DrinkType.milkshake;
            fox.KnownTricks.Add(TricksType.sing);
            fox.KnownTricks.Add(TricksType.code);
            return View(fox);
        }
    }
}

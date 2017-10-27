using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GreetSomeone.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GreetSomeone.Controllers
{
    public class HomeController : Controller
    {
        GiveName giveName;

        public HomeController(GiveName giveName)
        {
            this.giveName = giveName;
        }

        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            return View(giveName);
        }

        [HttpPost]
        [Route("")]
        public IActionResult SubmitName(GiveName giveName)
        {
            return RedirectToAction("Final", giveName);
        }

        [HttpGet]
        [Route("greet")]
        public IActionResult Final(GiveName giveName)
        {
            return View(giveName);
        }
    }
}

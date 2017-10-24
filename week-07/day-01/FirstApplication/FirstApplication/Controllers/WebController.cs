using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FirstApplication.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FirstApplication.Controllers
{
    [Route("web")]
    public class WebController : Controller
    {
        public static int counter = 0;
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        [Route("greeting")]
        public IActionResult Greeting(string inputName)
        {
            var greeting = new Greeting(counter, inputName)
            {
                Id = ++counter,
                Content = inputName
            };

            return View(greeting);
        }
    }
}

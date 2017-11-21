using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using P01HelloWorld.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace P01HelloWorld.Controllers
{
    [Route("api")]
    public class RESTController : Controller
    {
        public static int counter = 0;
        
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        [Route("greeting")]
        public IActionResult Greeting([FromQuery] string name)
        {
            return new JsonResult(new Greeting() { Id = ++counter, Content = $"Hello, {name}"});
        }
    }
}

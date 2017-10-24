using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FirstApplication.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FirstApplication.Controllers
{
    [Route("api")]
    public class RESTController : Controller
    {
        // GET: /<controller>/

        public static int counter = 0;

        public IActionResult Index()
        {
            return View();
        }

        [Route("greeting")]
        public IActionResult Greeting(string name)
        {
            counter++;
            var myGreeting = new Greeting(counter, name);
            return new JsonResult(myGreeting);
        }
    }
}

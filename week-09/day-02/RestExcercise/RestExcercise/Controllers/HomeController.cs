using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RestExcercise.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RestExcercise.Controllers
{
    [Route("/")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return File("index.html", "text/html");
        }

        [HttpGet]
        [Route("/doubling")]
        public IActionResult Doubling([FromQuery] int? input)
        {
            if (input == null)
            {
                return Json(new { error = "Please provide an input!" });
            }
            else
            {
                return Json(new { received = input, result = input * 2 });
            }
        }

        [HttpGet]
        [Route("/greeter")]
        public IActionResult Greeting([FromQuery] string name, [FromQuery] string title)
        {
            if (name == null)
            {
                return Json(new { error = "Please provide a name!" });
            }
            else if (title == null)
            {
                return Json(new { error = "Please provide a title!" });
            }
            else
            {
                return Json(new { welcome_message = $"Oh, hi there {name}, my dear {title}!" });
            }
        }

        [HttpGet]
        [Route("/appenda/{appendable}")]
        [Route("/appenda")]
        public IActionResult AppendA([FromRoute] string appendable)
        {
            if (appendable == null)
            {
                return NotFound();
            }
            else
            {
                return Json(new { appended = $"{appendable}a" });
            }
        }

        [HttpPost]
        [Route("/dountil/{what}")]
        [Route("/dountil")]
        public IActionResult DoUntil([FromBody] DoUntil until, string what)
        {
            if (until == null || until.Until == 0)
            {
                return Json(new { error = "Please provide a number!" });
            }
            if (what == "sum")
            {
                int sumOfNumbers = 0;
                for (int i = 0; i <= until.Until; i++)
                {
                    sumOfNumbers += i;
                }
                return Json(new { result = sumOfNumbers });
            }
            else if (what == "factor")
            {
                int multiplyOfNumbers = 1;
                for (int i = 1; i <= until.Until; i++)
                {
                    multiplyOfNumbers *= i;
                }
                return Json(new { result = multiplyOfNumbers });
            }
            else
            {
                return NotFound();
            }
        }
    }
}

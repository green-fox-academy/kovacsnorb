using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RestPractice.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RestPractice.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
        public IActionResult Index()
        {
            return File("index.html", "text/html");
        }

        [HttpGet]
        [Route("/doubling")]
        public IActionResult Double([FromQuery] string input)
        {
            if (input is null)
            {
                return Json(new Error("an input"));
            }
            else
            {
                return Json(new Doubling(int.Parse(input)));
            }
        }

        [HttpGet]
        [Route("/greeter")]
        public IActionResult Greet([FromQuery] string name, string title)
        {
            //if (name == null && title == null)
            //{
            //    return Json(new Error("a name and a title"));
            //}
            //else 
            if (name == null)
            {
                return Json(new Error("a name"));
            }
            else if (title == null)
            {
                return Json(new Error("a title"));
            }
            else
            {
                return Json(new Welcome(name, title));
            }
        }

        [HttpGet]
        [Route("/appenda/{inputFromRoute}")]
        [Route("/appenda")]
        public IActionResult Append([FromRoute] string inputFromRoute)
        {
            if (inputFromRoute != null)
            {
                return Json(new Append(inputFromRoute));
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPost]
        [Route("/dountil/{what}")]
        [Route("/dountil")]
        public IActionResult Dountil([FromBody] DoUntilObj until, [FromRoute] string what)
        {
            if (until is null || until.until == 0)
            {
                return Json(new Error("a number"));
            }
            else if (what is null)
            {
                return Json(new Error("an operation"));
            }
            else
            {
                return Json(new Dountil(what, until));
            }           
        }

        [HttpPost]
        [Route("/arrays")]
        public IActionResult ArrayHandler([FromBody] OperationObj inputOperation)
        {
            if (inputOperation.what == "" || inputOperation.what is null)
            {
                return Json(new Error("what to do with the numbers"));
            }
            else if (inputOperation.numbers is null || inputOperation.numbers.Length == 0)
            {
                return Json(new Error("what numbers to do the operation with"));
            }
            else
            {
                return Json(new Operation(inputOperation));
            }
        }
    }
}

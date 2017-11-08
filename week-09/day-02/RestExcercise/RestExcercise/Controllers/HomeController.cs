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
        public IActionResult Greeting([FromQuery] string name, string title)
        {
            if (name == null)
            {
                return Json(new ErrorMessage("name"));
            }
            else if (title == null)
            {
                return Json(new ErrorMessage("title"));
            }
            else
            {
                return Json(new WelcomeMessage(name, title));
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


        [HttpPost]
        [Route("/arrays")]
        public IActionResult ArrayHandler([FromBody] ArrayToExecute arrayToExecute)
        {
            if (arrayToExecute == null)
            {
                return Json(new { error = "Please provide input data!" });
            }
            else if (arrayToExecute.Numbers.Length == 0)
            {
                return Json(new { error = $"Please provide what numbers to do the {arrayToExecute.What}!" });
            }
            else if (arrayToExecute.What == "")
            {
                return Json(new { error = "Please provide what to do with the numbers!" });
            }

            if (arrayToExecute.What == "sum")
            {
                int sumOfNumbers = 0;
                for (int i = 0; i <= arrayToExecute.Numbers.Length - 1; i++)
                {
                    sumOfNumbers += arrayToExecute.Numbers[i];
                }
                return Json(new { result = sumOfNumbers });
            }
            else if (arrayToExecute.What == "multiply")
            {
                int multiplyOfNumbers = 1;
                for (int i = 0; i <= arrayToExecute.Numbers.Length - 1; i++)
                {
                    multiplyOfNumbers *= arrayToExecute.Numbers[i];
                }
                return Json(new { result = multiplyOfNumbers });
            }
            else if (arrayToExecute.What == "double")
            {
                int[] arrayOfNumbers = new int[arrayToExecute.Numbers.Length];
                for (int i = 0; i <= arrayToExecute.Numbers.Length - 1; i++)
                {
                    arrayOfNumbers[i] = 2 * arrayToExecute.Numbers[i];
                }
                return Json(new { result = arrayOfNumbers});
            }
            else
            {
                return NotFound();
            }
        }
    }
}

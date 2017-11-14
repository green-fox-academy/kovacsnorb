﻿using System;
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
        public IActionResult Index([FromQuery] string input)
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
        public IActionResult Index([FromQuery] string name, string title)
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
    }
}
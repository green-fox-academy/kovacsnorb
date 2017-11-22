using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using P03BankOfSimba.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace P03BankOfSimba.Controllers
{
    public class SimbaController : Controller
    {
        [Route("simba")]
        public IActionResult SimbaAccount()
        {
            var account = new BankAccount("Simba", 2000, Animal.Lion);
            return View(account);
        }
    }
}

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
            var account = new BankAccount("Simba", 2000, Animal.Lion, false, true);
            return View(account);
        }

        [Route("accountlist")]
        public IActionResult ListOfAccounts()
        {
            var accountList = new List<BankAccount>()
            {
                new BankAccount("Simba", 2000, Animal.Lion, false, true),
                new BankAccount("Pityuka", 5000, Animal.Parrot, false, true),
                new BankAccount("Sharky", 600, Animal.Shark, true, false),
                new BankAccount("Bobo", 4700, Animal.Monkey, false, false),
                new BankAccount("Jalala", 17889, Animal.Lion, false, false),
                new BankAccount("Lilike", 1400, Animal.Parrot, false, true),
                new BankAccount("Szonja", 35576, Animal.Lion, false, true),
            };

            return View(accountList);
        }
    }
}

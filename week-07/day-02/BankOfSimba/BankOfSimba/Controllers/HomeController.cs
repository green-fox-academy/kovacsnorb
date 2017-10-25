using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BankOfSimba.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BankOfSimba.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        [Route("simba")]
        public IActionResult GetSimba()
        {
            var bankAccount = new BankAccount("Simba", "2000", "Animal.Lion", "Zebra", true);
            return View(bankAccount);
        }

        [Route("account")]
        public IActionResult GetAccounts()
        {
            var bankAccount = new BankAccount();

            bankAccount.accountList.Add(new BankAccount("Timon", "1500", "Animal.Meerkat", "Zebra", false));
            bankAccount.accountList.Add(new BankAccount("Pumbaa", "760", "Animal.Warthog", "Zebra", true));
            bankAccount.accountList.Add(new BankAccount("Mufasa", "17690", "Animal.Lion", "Zebra", false));
            bankAccount.accountList.Add(new BankAccount("Sarabi", "7800", "Animal.Lion", "Zebra", false));
            bankAccount.accountList.Add(new BankAccount("Nala", "2300", "Animal.Lion", "Zebra", true));
            bankAccount.accountList.Add(new BankAccount("Zazu", "21", "Animal.Hornbill", "Zebra", false));
            return View(bankAccount);
        }
    }
}

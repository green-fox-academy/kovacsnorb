using Groot.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Groot.Services
{
    public class CargoService : Controller
    {
        public IActionResult ShowActualCargo()
        {
            return Json(new ActualCargo());
        }
    }
}

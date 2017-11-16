using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Groot.Models;
using System.Net;

namespace Groot.Services
{
    public class ArrowService : Controller
    {
        public IActionResult ArrowCalculator(double distance, double time)
        {
            if (time == 0 || distance < 0)
            {
                return new NotFoundObjectResult(new Error());

            }
            else
            {
                return Json(new CalculateSpeed(distance, time));
            }
        }
    }
}

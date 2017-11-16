using Groot.Models;
using Microsoft.AspNetCore.Mvc;

namespace Groot.Services
{
    public class GuardianService : Controller
    {
        public IActionResult GuardianTranslator(string message)
        {
            if (message is null)
            {
                return new NotFoundObjectResult(new Error());
                //return new Error();
            }
            else
            {
                return Json(new TranslatedGroot(message));
            }
        }
    }
}

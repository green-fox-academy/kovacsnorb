using Groot.Models;
using Microsoft.AspNetCore.Mvc;

namespace Groot.Services
{
    public class GuardianService : Controller
    {
        public JsonResult GuardianTranslator(string message)
        {
            if (message is null)
            {
                return Json(new Error());
            }
            else
            {
                return Json(new TranslatedGroot(message));
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SchoolDataBaseTest.Repositories;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SchoolDataBaseTest.Controllers
{
    public class StudentInfoController : Controller
    {
        StudentInfoRepository studentInfoRepository;

        public StudentInfoController(StudentInfoRepository studentInfoRepository)
        {
            this.studentInfoRepository = studentInfoRepository;
        }

        [Route("studentinfo")]
        public IActionResult StudentInfo()
        {
            return View();
        }
    }
}

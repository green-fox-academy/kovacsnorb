using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SchoolDataBaseTest.Repositories;
using SchoolDataBaseTest.Models;

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

        [Route("api/students")]
        public IActionResult Students()
        {
            return Json(studentInfoRepository.GetStudents());
        }

        [Route("api/addresses")]
        public IActionResult Addresses()
        {
            var studentList = new List<StudentAddress>();
            studentList = studentInfoRepository.GetAddresses();
            return new JsonResult(studentList);
        }

        [Route("studentinfo")]
        public IActionResult StudentInfo()
        {
            var studentList = new List<StudentAddress>();
            studentList = studentInfoRepository.GetAddresses();
            return View(studentList);
        }

        [Route("initialstudent")]
        public IActionResult AddNewStudent()
        {
            studentInfoRepository.AddStudent("Nagy Péter");
            studentInfoRepository.AddStudent("Gipsz Jakab");
            studentInfoRepository.AddStudent("Kiss Mária");
            return Ok();
        }

        [Route("initialaddress")]
        public IActionResult AddNewAddress()
        {
            studentInfoRepository.AddAddress("Fo utca 4.", "Budapest", "Hungary", 1111, 3);
            studentInfoRepository.AddAddress("Hegyes sor 121.", "Vác", "Hungary", 2116, 2);
            studentInfoRepository.AddAddress("Nap tér 14.", "Cegléd", "Hungary", 3125, 1);

            return Ok();
        }

        [Route("addstudent")]
        public IActionResult AddOneStudent([FromQuery] string surname, string firstname)
        {
            studentInfoRepository.AddStudent($"{surname} {firstname}");
            return Ok();
        }

        [Route("addaddress")]
        public IActionResult AddOneAddress([FromQuery] string streetname, int housenumber, string city, string country, int zipcode, int studentId)
        {
            studentInfoRepository.AddAddress($"{streetname} utca {housenumber}.", city, country, zipcode, studentId);
            return Ok();
        }
    }
}

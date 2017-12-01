using Microsoft.EntityFrameworkCore;
using SchoolDataBaseTest.Entities;
using SchoolDataBaseTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolDataBaseTest.Repositories
{
    public class StudentInfoRepository
    {
        StudentInfoContext studentInfoContext;

        public StudentInfoRepository(StudentInfoContext studentInfoContext)
        {
            this.studentInfoContext = studentInfoContext;
        }

        public List<Student> GetStudents()
        {
            return studentInfoContext.Students.Include(a => a.Address).ToList();
        }

        public List<StudentAddress> GetAddresses()
        {
            return studentInfoContext.StudentAddresses.Include(a => a.Student).ToList();
        }

        public void AddStudent(string name)
        {
            var student = new Student()
            {
                StudentName = name,
            };

            studentInfoContext.Students.Add(student);
            studentInfoContext.SaveChanges();
        }

        public void AddAddress(string address, string city, string country, int zipcode, int studentId)
        {
            var myAddress = new StudentAddress()
            {
                Address = address,
                City = city,
                Country = country,
                Zipcode = zipcode,
                Student = studentInfoContext.Students.Where(s => s.StudentId == studentId).FirstOrDefault()
            };

            studentInfoContext.StudentAddresses.Add(myAddress);
            studentInfoContext.SaveChanges();
        }
    }
}

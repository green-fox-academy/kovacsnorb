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

        public List<Grade> GetGrades()
        {
            return studentInfoContext.Grades.Include(a => a.Students).ToList();
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

        public void AddGrade(string grade, string gradeAnimal)
        {
            var myGrade = new Grade()
            {
                GrandeName = grade,
                GradeAnimal = gradeAnimal
            };

            studentInfoContext.Grades.Add(myGrade);
            studentInfoContext.SaveChanges();
        }

        public void SetGrade(int grade, int studentId)
        {
            var myStudent = studentInfoContext.Students.Where(a => a.StudentId == studentId).FirstOrDefault();
            var myGrade = studentInfoContext.Grades.Where(a => a.GradeId == grade).FirstOrDefault();
            myStudent.Grade = myGrade;

            studentInfoContext.SaveChanges();
        }
    }
}

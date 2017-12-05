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
            return studentInfoContext.Students.Include(a => a.Address).Include(a => a.Grade).Include(a => a.StudentSubjects).ToList();
        }

        public List<StudentAddress> GetAddresses()
        {
            return studentInfoContext.StudentAddresses.Include(a => a.Student).ToList();
        }

        public List<Grade> GetGrades()
        {
            return studentInfoContext.Grades.Include(a => a.Students).ToList();
        }

        public List<Subject> GetSubjects()
        {
            return studentInfoContext.Subjects.Include(a => a.StudentSubjects).ToList();
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

        public void AddSubject(string subject)
        {
            var mySubject = new Subject()
            {
                SubjectName = subject,
            };

            studentInfoContext.Subjects.Add(mySubject);
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

        public void SetSubject(int subject, int studentId)
        {
            var myStudent = studentInfoContext.Students.Where(a => a.StudentId == studentId).FirstOrDefault();
            var mySubject = studentInfoContext.Subjects.Where(a => a.SubjectId == subject).FirstOrDefault();

            var studentSubjects = new StudentSubject
            {
                Student = myStudent,
                Subject = mySubject
            };

            studentInfoContext.StudentSubjects.Add(studentSubjects);
            studentInfoContext.SaveChanges();
        }
    }
}

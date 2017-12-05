using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolDataBaseTest.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }

        //[JsonIgnore]
        public StudentAddress Address { get; set; }
        //[JsonIgnore]
        public Grade Grade { get; set; }

        public ICollection<StudentSubject> StudentSubjects { get; set; }
    }
}

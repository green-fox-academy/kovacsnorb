using System;
using System.Collections.Generic;
using System.Text;

namespace _01_GreenFoxOrganization
{
    class PallidaClass
    {
        private string className;
        private List<Student> students = new List<Student>();
        private List<Mentor> mentors = new List<Mentor>();

        public PallidaClass(string className)
        {
            this.className = className;
            this.students = null;
            this.mentors = null;
        }

        public void AddStudent(Student student)
        {
            students.Add(student);
        }

        public void AddMentor(Mentor mentor)
        {
            mentors.Add(mentor);
        }

        public void Info()
        {
            Console.WriteLine("Pallida {0} class has {1} students and {2} mentors.", this.className, 
                this.students.Count, this.mentors.Count);
        }
    }
}

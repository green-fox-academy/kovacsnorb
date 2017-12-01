using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolDataBaseTest.Models
{
    public class Grade
    {
        public int GradeId { get; set; }
        public string GrandeName { get; set; }
        public string GradeAnimal { get; set; }

        //[JsonIgnore]
        public ICollection<Student> Students { get; set; }
    }
}

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolDataBaseTest.Models
{
    public class StudentSubject
    {
        [JsonIgnore]
        public int StudentId { get; set; }
        [JsonIgnore]
        public Student Student { get; set; }
        
        public int SubjectId { get; set; }
        [JsonIgnore]
        public Subject Subject { get; set; }
    }
}

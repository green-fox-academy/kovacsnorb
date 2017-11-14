using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestPractice.Models
{
    public class Append
    {
        public string appended;

        public Append(string input)
        {
            appended = $"{input}a";
        }
    }
}

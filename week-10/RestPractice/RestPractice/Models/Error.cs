using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestPractice.Models
{
    public class Error
    {
        public string error;

        public Error(string input)
        {
            error = $"Please provide {input}!";
        }
    }
}

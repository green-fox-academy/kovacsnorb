using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestExcercise.Models
{
    public class ErrorMessage
    {
        public string error;

        public ErrorMessage(string missingPart)
        {
            error = $"Please provide a {missingPart}!";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Groot.Models
{
    public class Error : IGroot
    {
        public string error;

        public Error()
        {
            error = "I am Groot!";
        }
    }
}

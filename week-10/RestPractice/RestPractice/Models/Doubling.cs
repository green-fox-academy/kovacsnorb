using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestPractice.Models
{
    public class Doubling
    {
        public int received;
        public int result;

        public Doubling(int input)
        {
            received = input;
            result = input * 2;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestPractice.Models
{
    public class Dountil
    {
        public long result;

        public Dountil(string inputWhat, DoUntilObj inputUntil)
        {
            if (inputWhat == "sum")
            {
                for (int i = 0; i <= inputUntil.until; i++)
                {
                    result += i;
                }
            }
            else if (inputWhat == "factor")
            {
                result = 1;
                for (int i = 1; i <= inputUntil.until; i++)
                {
                    result *= i;
                }
            }
        }
    }
}

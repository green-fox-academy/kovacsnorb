using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Fibonacci
{
    public class Fibonacci
    {
        public int FibonacciCalculator(int nthFibo)
        {
            if (nthFibo < 1)
            {
                Console.WriteLine("Give me a number >= 1.");
                return -1;
            }
            else if (nthFibo == 1)
            {
                return 0;
            }
            else if (nthFibo == 2)
            {
                return 1;
            }
            else
            {
                int previousMinusOne = 0;
                int previous = 1;
                int resultOfFibonacci = 0;

                for (int i = 0; i < nthFibo - 2; i++)
                {
                    resultOfFibonacci = previousMinusOne + previous;
                    previousMinusOne = previous;
                    previous = resultOfFibonacci;
                }
                return resultOfFibonacci;
            }
        }
    }
}

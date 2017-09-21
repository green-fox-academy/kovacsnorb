using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_SumDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            // Given a non-negative int n, return the sum of its digits recursively (no loops). 
            // Note that mod (%) by 10 yields the rightmost digit (126 % 10 is 6), while 
            // divide (/) by 10 removes the rightmost digit (126 / 10 is 12).
            Console.Write("Give me a number and I sum the digits of this number: ");
            int userInput = int.Parse(Console.ReadLine());
            Console.WriteLine(SumDigits(userInput));
            Console.ReadLine();
        }

        public static int SumDigits(int input)
        {
            int mod = input % 10;
            int divide = input / 10;

            if (divide == 0)
            {
                return mod;
            }
            else
            {
                return mod + SumDigits(divide);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_NumberAdder
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a recursive function that takes one parameter: n and adds numbers from 1 to n.
            Console.Write("Give me a number and I sum numbers from 1 to your number: ");
            int userInput = int.Parse(Console.ReadLine());
            Console.WriteLine(NumberAdder(userInput));
            Console.ReadLine();
        }

        public static int NumberAdder(int input)
        {
            if (input == 1)
            {
                return 1;
            }
            else
            {
                return input + NumberAdder(input - 1);
            }
        }
    }
}

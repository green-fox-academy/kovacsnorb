using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a recursive function that takes one parameter: n and counts down from n.
            Console.Write("Give me a number: ");
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine(Counter(input));
            Console.ReadLine();
        }

        public static int Counter(int input)
        {
            if (input == 1)
            {
                return 1;
            }
            else
            {
                Console.WriteLine(input);
                input -= 1;
                return Counter(input);
            }
        }
    }
}

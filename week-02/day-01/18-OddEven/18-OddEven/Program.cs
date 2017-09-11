using System;

namespace _18_OddEven
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads a number form the standard input,
            // Than prints "Odd" if the number is odd, or "Even" it it is even.

            Console.Write("Give me a number: ");
            int number = int.Parse(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine(number + " is an EVEN number.");
            }
            else
            {
                Console.WriteLine(number + " is an ODD number.");
            }

            Console.ReadLine();
        }
    }
}

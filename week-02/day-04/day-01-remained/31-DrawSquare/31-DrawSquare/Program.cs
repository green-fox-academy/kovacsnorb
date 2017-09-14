using System;

namespace _31_DrawSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads a number from the standard input, then draws a
            // square like this:
            //
            //
            // %%%%%
            // %   %
            // %   %
            // %   %
            // %   %
            // %%%%%
            //
            // The square should have as many lines as the number was

            Console.Write("Give me a number: ");
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number - 1; i++)
            {
                Console.Write("%");
            }
            Console.WriteLine("%");

            for (int i = 0; i < number - 2; i++)
            {
                Console.Write("%");
                for (int j = 0; j < number - 2; j++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("%");

            }

            for (int i = 0; i < number - 1; i++)
            {
                Console.Write("%");
            }
            Console.WriteLine("%");
 
            Console.ReadLine();
        }
    }
}

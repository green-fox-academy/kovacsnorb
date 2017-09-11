using System;

namespace _29_DrawPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads a number from the standard input, then draws a
            // pyramid like this:
            //
            //
            //    *
            //   ***
            //  *****
            // *******
            //
            // The pyramid should have as many lines as the number was

            Console.Write("Give a number: ");
            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {
                for (int j = 0; j < (number - i); j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < (2 * (i + 1) - 1); k++)
                {
                    Console.Write("*");
                }
                for (int l = 0; l < (number - i) - 1; l++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine(" ");
            }
            Console.ReadLine();
        }
    }
}

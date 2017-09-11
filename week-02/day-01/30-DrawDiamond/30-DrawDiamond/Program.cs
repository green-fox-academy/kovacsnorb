using System;

namespace _30_DrawDiamond
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads a number from the standard input, then draws a
            // diamond like this:
            //
            //
            //    *
            //   ***
            //  *****
            // *******
            //  *****
            //   ***
            //    *
            //
            // The diamond should have as many lines as the number was

            Console.Write("Give a number: ");
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number / 2 + 1; i++)
                {
                    for (int j = 0; j < (number / 2 - i + 1); j++)
                    {
                        Console.Write(" ");
                    }
                    for (int k = 0; k < (2 * (i + 1) - 1); k++)
                    {
                        Console.Write("*");
                    }
                    for (int l = 0; l < (number / 2 - i); l++)
                    {
                        Console.Write(" ");
                    }
                    Console.WriteLine(" ");
                }
            if (number % 2 == 1)
            {
                for (int i = 0; i < number / 2; i++)
                {
                    for (int j = 0; j < i + 2; j++)
                    {
                        Console.Write(" ");
                    }
                    for (int k = 0; k < (number - 2 * i - 2); k++)
                    {
                        Console.Write("*");
                    }
                    for (int l = 0; l < i + 1; l++)
                    {
                        Console.Write(" ");
                    }
                    Console.WriteLine(" ");
                }
            }
            else
            {
                for (int i = 0; i < number / 2 + 1; i++)
                {
                    for (int j = 0; j < i + 1; j++)
                    {
                        Console.Write(" ");
                    }
                    for (int k = 0; k < (number - 2 * i + 1); k++)
                    {
                        Console.Write("*");
                    }
                    for (int l = 0; l < i; l++)
                    {
                        Console.Write(" ");
                    }
                    Console.WriteLine(" ");
                }
            }
            Console.ReadLine();
        }
    }
}

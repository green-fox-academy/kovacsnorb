using System;

namespace _32_DrawDiagonal
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
            // %%  %
            // % % %
            // %  %%
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

            int counter = 1;

            for (int j = 0; j < number - 2; j++)
            {
                for (int i = 0; i < number - 1; i++)
                {
                    if (i == 0 || (i == counter))
                    {
                        Console.Write("%");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine("%");
                counter++;
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

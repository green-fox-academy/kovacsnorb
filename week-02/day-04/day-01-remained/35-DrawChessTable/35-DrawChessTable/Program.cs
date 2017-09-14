using System;

namespace _35_DrawChessTable
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crate a program that draws a chess table like this
            //
            // % % % %
            //  % % % %
            // % % % %
            //  % % % %
            // % % % %
            //  % % % %
            // % % % %
            //  % % % %
            //
            int sizeOfTable = 8;

            for (int j = 0; j < 4; j++)
            {
                for (int i = 0; i < sizeOfTable - 1; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.Write("%");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine(" ");

                for (int i = 0; i < sizeOfTable - 1; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("%");
                    }
                }
                Console.WriteLine("%");
            }

            Console.ReadLine();
        }
    }
}

using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("while loop");
            int a = 0;
            while (a < 10)
            {
                Console.WriteLine(a++);
            }

            Console.WriteLine("\n\n do while loop:");
            int b = 0;
            do
            {
                Console.WriteLine(b++);
            } while (b < 10);

            Console.WriteLine("\n\n for loop:");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }
    }
}

using System;

namespace _01_Doubling
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create an integer variable named `ak` and assign the value `123` to it
            // - Create a function called `doubling` that doubles it's input parameter
            // - Print the result of `doubling(ak)`

            int ak = 123;
            Console.WriteLine(Doubling(ak));
            Console.ReadLine();
        }

        public static int Doubling(int number01)
        {
            return 2 * number01;
        }
    }
}

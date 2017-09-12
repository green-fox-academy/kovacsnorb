using System;

namespace _03_AppendA
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create a string variable named `am` and assign the value `kuty` to it
            // - Write a function called `appendA` that gets a string as an input
            //   and appends an 'a' character to its end
            // - Print the result of `appendA(am)`
            string am = "kuty";
            Console.WriteLine(AppendA(am));
            Console.ReadLine();
        }

        public static string AppendA(string input)
        {
            return input + "a";
        }
    }
}

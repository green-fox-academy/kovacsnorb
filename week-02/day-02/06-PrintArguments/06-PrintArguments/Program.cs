using System;

namespace _06_PrintArguments
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create a function called `printer`
            //   which prints the input String parameters
            // - It can have any number of parameters

            // Examples
            // printer("first")
            // printer("first", "second")
            // printer("first", "second", "third", "fourh")
            // ...

            string input01 = "kutya";



            Printer(input01);
            Console.ReadLine();
        }

        public static void Printer(params string[] givenString)
        {

        }


    }
}

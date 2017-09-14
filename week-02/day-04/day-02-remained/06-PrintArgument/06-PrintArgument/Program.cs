using System;

namespace _06_PrintArgument
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
            string[] text = new string[8] { "elso", "masodik", "harmadik", "negyedik", "otodik", "hatodik", "hetedik", "nyolcadik" };
            
            Printer(text);
            Console.ReadLine();
        }

        public static void Printer(string[] input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                Console.Write("{0}, ", input[i]);
            }

        }

    }
}

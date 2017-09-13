using System;
using System.Collections.Generic;
using System.Text;

namespace Strings_05
{
    class Program
    {
        static void Main(string[] args)
        {
            string reversed = ".eslaf eb t'ndluow ecnetnes siht ,dehctiws erew eslaf dna eurt fo sgninaem eht fI";

            // Create a function that can reverse a String, which is passed as the parameter
            // Use it on this reversed string to check it!

            Console.WriteLine(ReverseFunction(reversed));
            Console.ReadLine();
        }

        public static string ReverseFunction(string input)
        {
            string reversedText = "";
            for (int i=0; i < input.Length; i++)
            {
                reversedText = reversedText + input[input.Length - i - 1];
            }
            return reversedText;
        }
    }
}

using System;
using System.Collections.Generic;

namespace Lists_07
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<string> { "What", "I", "do", "create,", "I", "cannot", "not", "understand." };

            // Accidentally I messed up this quote from Richard Feynman.
            // Two words are out of place
            // Your task is to fix it by swapping the right words with code

            // Also, print the sentence to the output with spaces in between.

            string temp = list[2];
            list[2] = list[5];
            list[5] = temp;

            for (int i = 0; i < list.Count; i++)
            {
                Console.Write("{0} ", list[i]);
            }

            Console.ReadLine();
        }
    }
}

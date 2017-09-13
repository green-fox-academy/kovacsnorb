using System;
using System.Collections.Generic;

namespace Lists_06
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int> { 2, 4, 6, 8, 10, 12, 14, 16 };

            // Check if list contains all of the following elements: 4,8,12,16
            // Print "true" if it contains all, otherwise print "false"
            // Can you do both the different approaches you tried in the previous one?

            int numToCheck01 = 4;
            int numToCheck02 = 8;
            int numToCheck03 = 12;
            int numToCheck04 = 16;

            int counter = 0;

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == numToCheck01 || list[i] == numToCheck02 || list[i] == numToCheck03 || list[i] == numToCheck04)
                    counter++;
            }

            if (counter == 4)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }

            Console.ReadLine();

        }
    }
}

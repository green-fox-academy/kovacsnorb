using System;
using System.Collections.Generic;

namespace Lists_05
{
    class Program
    {
        static void Main(string[] args)
        {
            var List = new List<int> { 1, 2, 3, 4, 5 };

            // Check if the arrayList contains "7" if it contains print "Hoorray" otherwise print "Noooooo"
            // Do this again with a different solution using different list functions!

            int counter = 0;

            for (int i = 0; i < List.Count; i++)
            {
                if (List[i] == 7)
                {
                    counter++;
                    break;
                }
            }

            if (counter == 1)
            {
                Console.WriteLine("Hoorray");
            }
            else
            {
                Console.WriteLine("Nooooo");
            }

            Console.ReadLine();
        }
    }
}

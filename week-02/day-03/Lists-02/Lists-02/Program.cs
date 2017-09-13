using System;
using System.Collections.Generic;

namespace Lists_02
{
    class Program
    {
        static void Main(string[] args)
        {
            var girls = new List<string> { "Eve", "Ashley", "Bözsi", "Kat", "Jane" };
            var boys = new List<string> { "Joe", "Fred", "Béla", "Todd", "Neef", "Jeff" };
            var order = new List<string>();

            // Join the two lists by matching one girl with one boy in the order list
            // Exepected output: "Eve", "Joe", "Ashley", "Fred"...

            int lengthOfList = 0;

            if (girls.Count >= boys.Count)
            {
                lengthOfList = girls.Count;
            }
            else
            {
                lengthOfList = boys.Count;
            }

            for (int i = 0; i < lengthOfList - 1; i++)
                {
                    order.Insert(2 * i, girls[i]);
                    order.Insert(2 * i + 1, boys[i]);
                }

            for (int i = 0; i < (boys.Count + girls.Count) - 1; i++)
                {
                    Console.Write("{0}, ", order[i]);
                }

            Console.ReadLine();
        }
    }
}

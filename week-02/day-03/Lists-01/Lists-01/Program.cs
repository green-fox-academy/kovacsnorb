using System;
using System.Collections.Generic;

namespace Lists_01
{
    class Program
    {
        static void Main(string[] args)
        {
            var planetList = new List<string> { "Mercury", "Venus", "Earth", "Mars", "Jupiter", "Uranus",
            "Neptune" };


            // Saturn is missing from the planetList
            // Insert it into the correct position

            planetList.Insert(5, "Saturn");

            for(int i = 0; i < planetList.Count; i++)
            {
                Console.WriteLine(planetList[i]);
            }
            Console.ReadLine();
        }
    }
}

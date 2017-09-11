using System;

namespace _06_CodingHours.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            // An average Green Fox attendee codes 6 hours daily
            // The semester is 17 weeks long
            //
            // Print how many hours is spent with coding in a semester by an attendee,
            // if the attendee only codes on workdays.
            //
            // Print the percentage of the coding hours in the semester if the average
            // work hours weekly is 52
            Console.WriteLine("Number of hours spent with coding: " + (17 * 5 * 6));
            Console.WriteLine("Average of coding hours: " + (17.0 * 5.0 * 6.0)/(17 * 52)*100);
            Console.ReadLine();
        }
    }
}

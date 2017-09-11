using System;

namespace _15_MileToKmConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for an integer that is a distance in kilometers,
            // then it converts that value to miles and prints it

            Console.Write("Write a distance in kilometers: ");
            int kilometer = int.Parse(Console.ReadLine());

            double miles = kilometer * 0.621371192;
            Console.WriteLine(kilometer + " kilometer(s) is/are " + miles + " miles.");
            Console.ReadLine();
        }
    }
}

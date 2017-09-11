using System;

namespace _12_Cuboid
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that stores 3 sides of a cuboid as variables (doubles)
            // The program should write the surface area and volume of the cuboid like:
            //
            // Surface Area: 600
            // Volume: 1000

            double a = 10;
            double b = 20;
            double c = 50;

            Console.WriteLine("a = " + a + ", b = " + b + ", c = " + c);

            double surface = 2 * (a * b + a * c + b * c);
            double volume = a * b * c;

            Console.WriteLine("Surface: " + surface + ", volume: " + volume);
            Console.ReadLine();
        }
    }
}

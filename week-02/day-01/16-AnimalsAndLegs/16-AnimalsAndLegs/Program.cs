using System;

namespace _16_AnimalsAndLegs
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for two integers
            // The first represents the number of chickens the farmer has
            // The seconf represents the number of pigs the farmer has
            // It should print how many legs all the animals have
            Console.Write("How many chickens has the farmer? ");
            int numberOfChickens = int.Parse(Console.ReadLine());
            Console.Write("How many pigs has the farmer? ");
            int numberOfPigs = int.Parse(Console.ReadLine());
            int numberOfLegs = numberOfChickens * 2 + numberOfPigs * 4;
            Console.WriteLine("The total number of legs are: " + numberOfLegs);
            Console.ReadLine();
        }
    }
}

using System;

namespace _21_PartyIndicator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for two numbers
            // Thw first number represents the number of girls that comes to a party, the
            // second the boys
            // It should print: The party is exellent!
            // If the the number of girls and boys are equal and there are more people coming than 20
            //
            // It should print: Quite cool party!
            // It there are more than 20 people coming but the girl - boy ratio is not 1-1
            //
            // It should print: Average party...
            // If there are less people coming than 20
            //
            // It should print: Sausage party
            // If no girls are coming, regardless the count of the people

            Console.Write("Number of boys: ");
            int numberOfBoys = int.Parse(Console.ReadLine());
            Console.Write("Number of girls: ");
            int numberOfGirls = int.Parse(Console.ReadLine());

            if (((numberOfBoys + numberOfGirls) > 20) && (numberOfBoys == numberOfGirls))
            {
                Console.WriteLine("The party is exellent!");
            }
            else if (((numberOfBoys + numberOfGirls) > 20) && (numberOfBoys != numberOfGirls) && (numberOfGirls != 0))
            {
                Console.WriteLine("Quite cool party!");
            }
            else if (((numberOfBoys + numberOfGirls) <= 20) && (numberOfGirls != 0))
            {
                Console.WriteLine("Average party...");
            }
            else if (numberOfGirls == 0)
            {
                Console.WriteLine("Sausage party");
            }
            else
            {
                Console.WriteLine("Error");
            }

            Console.ReadLine();


        }
    }
}

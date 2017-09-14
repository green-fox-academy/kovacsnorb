using System;

namespace _33_GuessTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that stores a number, and the user has to figure it out.
            // The user can input guesses, after each guess the program would tell one
            // of the following:
            //
            // The stored number is higher
            // The stried number is lower
            // You found the number: 8

            int storedNumber = 10;
            int userNumber = 0;

            Console.Write("Give me a number: ");
            userNumber = int.Parse(Console.ReadLine());

            while (userNumber != storedNumber)
            {
                if (userNumber > storedNumber)
                {
                    Console.WriteLine("The stored number is lower.");
                }
                else
                {
                    Console.WriteLine("The stored number is higher.");
                }
                Console.Write("Give me another number: ");
                userNumber = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("You found the number: " + storedNumber);
            Console.ReadLine();
        }

    }
}

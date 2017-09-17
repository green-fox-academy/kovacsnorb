using System;

namespace ArmstrongNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Give me a number to check: ");
            double userInput = double.Parse(Console.ReadLine());
            int length = userInput.ToString().Length;

            double userInputDuplication = userInput;
            double sum = 0;
            double toAdd = 0;
            double toSub = 0;

            for (int i = 0; i < length; i++)
            {
                toAdd = Math.Pow(Math.Truncate((userInputDuplication / Math.Pow(10, length - 1 - i))), length);
                toSub = Math.Truncate((userInputDuplication / Math.Pow(10, length - 1 - i))) * Math.Pow(10, length - 1 - i);
                sum += toAdd;
                userInputDuplication -= toSub;
            }

            if (sum == userInput)
            {
                Console.WriteLine("The " + userInput + " is an Armstrong number. The calculated value is: " + sum + ".");
            }
            else
            {
                Console.WriteLine("The " + userInput + " is NOT an Armstrong number. The calculated value is: " + sum + ".");
            }

            Console.ReadLine();
        }
    }
}

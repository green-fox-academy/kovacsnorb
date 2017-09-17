using System;

namespace GuessMyNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxNumberOfUser = GetMaxNumber();
            int numberToGuess = ProgramGuessNumber(maxNumberOfUser);
            GuessGame(maxNumberOfUser, numberToGuess);
        }

        public static int GetMaxNumber()
        {
            Console.Write("Give me the maximal number: ");
            int userMaxInput = int.Parse(Console.ReadLine());
            return userMaxInput;
        }

        public static int ProgramGuessNumber(int maxNumber)
        {
            Random randomNumber = new Random();
            return (int)Math.Truncate(randomNumber.NextDouble() * maxNumber + 1);
        }

        public static void GuessGame(int maxNumber, int randomNumber)
        {
            Console.WriteLine("I've the number between 1-" + maxNumber + ". You have 5 lives.");
            int numberOfLives = 5;

            do
            {
                int userInput = int.Parse(Console.ReadLine());
                if (userInput == randomNumber)
                {
                    Console.WriteLine("Congratulations. You won!");
                    break;
                }
                else if (userInput < randomNumber)
                {
                    numberOfLives--;
                    Console.WriteLine("Too low. You have " + numberOfLives + " lives left.");
                }
                else
                {
                    numberOfLives--;
                    Console.WriteLine("Too high. You have " + numberOfLives + " lives left.");
                }
            } while (numberOfLives > 0);
            Console.WriteLine("The number was: " + randomNumber);
            Console.ReadLine();
        }
    }
}

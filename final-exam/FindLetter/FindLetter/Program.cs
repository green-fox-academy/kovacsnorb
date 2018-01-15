using System;
using System.Collections.Generic;

namespace FindLetter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The search will be case insensitive!");
            Console.Write("Give me a string: ");
            string inputString = Console.ReadLine().ToLower();      
            Console.Write("Give me a letter: ");
            string originalInput = Console.ReadLine();

            Execute(inputString, originalInput);
        }

        public static List<int> FindOccurences(string myInputString, char myInputLetter)
        {
            List<int> myOutput = new List<int>();

            for (int i = 0; i < myInputString.Length; i++)
            {
                if (myInputString[i] == myInputLetter)
                {
                    myOutput.Add(i);
                }
            }

            return myOutput;
        }

        public static void PrintResult(char myInput, List<int> myList)
        {
            if (myList.Count == 0)
            {
                Console.WriteLine($"The letter \"{myInput}\" cannot be found in the string.");
            }
            else
            {
                Console.Write($"The letter \"{myInput}\" can be found at this index in the string: ");
                foreach (var element in myList)
                {
                    Console.Write($"[{element}] ");
                }
            }
        }

        public static void Execute(string inputString, string letter)
        {
            List<int> result = new List<int>();

            if (letter.Length == 1)
            {
                char inputLetter = Convert.ToChar(letter);
                inputLetter = Char.ToLower(inputLetter);

                result = FindOccurences(inputString, inputLetter);
                PrintResult(inputLetter, result);

                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Please, start again, and give me just one letter...");
                Console.ReadLine();
            }
        }
    }
}

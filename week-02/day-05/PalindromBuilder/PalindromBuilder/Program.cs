using System;

namespace PalindromBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Give me a word: ");
            string userInput = Console.ReadLine();
            char[] inputToChar = userInput.ToCharArray();
            string reverseUserInput = "";

            for (int i = 0; i < inputToChar.Length; i++)
            {
                reverseUserInput += inputToChar[inputToChar.Length - i - 1];
            }

            Console.WriteLine(userInput + reverseUserInput);
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;

namespace PalindromSearcher
{
    class Program
    {
        static void Main(string[] args)
        {
            ListPalindroms(CheckIfWordPalindrom(FillListWithPossibleWords(GiveMeAString())));
        }

        public static string GiveMeAString()
        {
            Console.Write("Give me a string: ");
            string userInput = Console.ReadLine();
            return userInput;
        }

        public static List<string> FillListWithPossibleWords(string input)
        {
            List<string> possible = new List<string>();

            for (int i = 3; i < input.Length + 1; i++)
            {
                for (int j = 0; j < input.Length - i + 1; j++)
                {
                    possible.Add(input.Substring(j, i));
                }
            }

            return possible;
        }

        public static List<string> CheckIfWordPalindrom(List<string> input)
        {
            List<string> palindrom = new List<string>();

            for (int j = 0; j < input.Count; j++)
            {
                string wordToCheck = input[j];
                int counter = 0;

                for (int i = 0; i < wordToCheck.Length / 2 + 1; i++)
                {
                    if (wordToCheck[i] != wordToCheck[wordToCheck.Length - 1 - i])
                    {
                        counter++;
                    }
                }

                if (counter == 0)
                {
                    palindrom.Add(wordToCheck);
                }

                counter = 0;
            }
            return palindrom;
        }

        public static void ListPalindroms(List<string> input)
        {
            Console.Write("Palindroms are: ");

            for (int i = 0; i < input.Count; i++)
            {
                Console.Write("{0}, ", input[i]);
            }

            Console.ReadLine();
        }
    }
}

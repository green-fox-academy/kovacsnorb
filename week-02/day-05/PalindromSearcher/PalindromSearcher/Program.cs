using System;
using System.Collections.Generic;

namespace PalindromSearcher
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Give me a string: ");
            string userInput = Console.ReadLine();
            List<string> possibleWords = new List<string>();
            List<string> palindroms = new List<string>();

            for (int i = 3; i < userInput.Length + 1; i++)
            {
                for (int j = 0; j < userInput.Length - i + 1; j++)
                {
                    possibleWords.Add(userInput.Substring(j, i));
                }
            }

            for (int j = 0; j < possibleWords.Count; j++)
            {
                string wordToCheck = possibleWords[j];
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
                    palindroms.Add(wordToCheck);
                }

                counter = 0;
            }

            Console.Write("Palindroms are: ");

            for (int i = 0; i < palindroms.Count; i++)
            {
                Console.Write("{0}, ", palindroms[i]);
            }

            Console.ReadLine();
        }
    }
}

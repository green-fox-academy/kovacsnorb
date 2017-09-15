using System;
using System.Collections.Generic;

namespace Anagram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Give me word one: ");
            string wordOne = Console.ReadLine();
            Console.Write("Give me word two: ");
            string wordTwo = Console.ReadLine();

            char[] listOne = FillTheList(wordOne);
            char[] listTwo = FillTheList(wordTwo);

            Array.Sort(listOne);
            Array.Sort(listTwo);

            bool isAnagram;

            if (listOne.Length == listTwo.Length)
            {
                int counter = 0;

                for (int i = 0; i < listOne.Length; i++)
                {
                    if (listOne[i] != listTwo[i])
                    {
                        counter++;
                    }
                }

                if (counter == 0)
                {
                    isAnagram = true;
                }
                else
                {
                    isAnagram = false;
                }
            }
            else
            {
                isAnagram = false;
            }

            Console.WriteLine(isAnagram);
            Console.ReadLine();
        }

        public static char[] FillTheList(string userInput)
        {
            char[] inputSplit = userInput.ToCharArray();
            return inputSplit;
        }
    }
}

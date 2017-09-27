using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_CountLetters
{
    public class CountLetters
    {
        public Dictionary<char, int> LetterCounter(string input)
        {
            char[] inputArray = input.ToCharArray();
            Array.Sort(inputArray);

            var resultDictionary = new Dictionary<char, int>();

            char tempChar;
            char previousTempChar = ' ';
            int tempCounter = 0;

            for (int i = 0; i < inputArray.Count(); i++)
            {
                tempChar = inputArray[i];

                if (tempChar != previousTempChar)
                {
                    foreach (char character in inputArray)
                    {
                        if (character == tempChar)
                        {
                            tempCounter++;
                        }
                    }
                    resultDictionary.Add(tempChar, tempCounter);
                    tempCounter = 0;
                    previousTempChar = tempChar;
                }
            }
            return resultDictionary;
        }
    }
}

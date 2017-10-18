using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_07
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a LINQ Expression to find the strings which starts with A and ends with I in the following array:

            string[] cities = { "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS" };

            List<string> myResults = FrequencyOfChars(cities);
            List<string> myResults2 = FrequencyOfCharsWithLambda(cities);

            Console.ReadLine();
        }

        public static List<string> FrequencyOfChars(string[] inputArray)
        {
            var aiWords =
                from strings in inputArray
                where strings[0] == 'A' && strings[strings.Length - 1] == 'I' 
                select strings;

            return aiWords.ToList();
        }

        public static List<string> FrequencyOfCharsWithLambda(string[] inputArray)
        {
            var aiWords = inputArray.Where(x => x.StartsWith("A") && x.EndsWith("I"));

            return aiWords.ToList();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_06
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a LINQ Expression to find the frequency of characters in a given string!

            string n = "hany ismetlodo karakter van ebben a szovegben";

            var myResult = FrequencyOfChars(n);
            var myResult2 = FrequencyOfCharsWithLambda(n);
            Console.ReadLine();
        }

        public static Dictionary<char, int> FrequencyOfChars(string inputString)
        {
            var countFrequency =
                from chars in inputString
                group chars by chars into frequencies
                select new { frequencies.Key, Count = frequencies.Count() };

            return countFrequency.ToDictionary(x => x.Key, x => x.Count);
        }

        public static Dictionary<char, int> FrequencyOfCharsWithLambda(string inputString)
        {
            var countFrequency = inputString.GroupBy(x => x).ToDictionary(x => x.Key, x => x.Count());

            return countFrequency;
        }
    }
}

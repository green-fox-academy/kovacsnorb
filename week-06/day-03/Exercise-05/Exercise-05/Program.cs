using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_05
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a LINQ Expression to find the frequency of numbers in the following array:

            //int[] n = new int[] { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };

            int[] n = new int[] { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };

            var myResult = FrequencyOfNumbers(n);
            var myResult2 = FrequencyOfNumbersWithLambda(n);
            Console.ReadLine();
        }

        public static Dictionary<int, int> FrequencyOfNumbers(int[] inputArray)
        {
            var countFrequency =
                from numbers in inputArray
                group numbers by numbers into frequencies
                select new { frequencies.Key, Count = frequencies.Count() };

            return countFrequency.ToDictionary(x => x.Key, x => x.Count);
        }

        public static Dictionary<int, int> FrequencyOfNumbersWithLambda(int[] inputArray)
        {
            var countFrequency = inputArray.GroupBy(x => x).ToDictionary(x => x.Key, x => x.Count());

            return countFrequency;
        }
    }
}

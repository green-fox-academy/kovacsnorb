using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_02
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a LINQ Expression to get the average value of the odd numbers from the following array:
            //int[] n = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };

            int[] n = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };

            double averageOfOddNumbers = GetAverageOfOddNumbersWithQuery(n);
            double averageOfOddNumbersWithLambda = GetAverageOfOddNumbersWithLambda(n);
            Console.ReadLine();
        }

        public static double GetAverageOfOddNumbersWithQuery(int[] inputArray)
        {
            IEnumerable<int> oddNumbers =
                from number in inputArray
                where number % 2 != 0
                select number;

            return oddNumbers.Average();
        }

        public static double GetAverageOfOddNumbersWithLambda(int[] inputArray)
        {
            double oddNumbers = inputArray.Where(number => number % 2 != 0).Average();

            return oddNumbers;
        }
    }
}

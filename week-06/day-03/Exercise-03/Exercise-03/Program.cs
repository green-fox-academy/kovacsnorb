using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_03
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a LINQ Expression to get the squared value of the positive numbers from the following array:

            //int[] n = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };

            int[] n = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };

            List<int> myResult = GetSquareValueOfPositiveNumbersWithQuery(n);
            List<int> myResultWithLambda = GetSquareValueOfPositiveNumbersWithLambda(n);

            Console.ReadLine();
        }

        public static List<int> GetSquareValueOfPositiveNumbersWithQuery(int[] inputArray)
        {
            IEnumerable<int> positiveNumbersSquare =
                from number in inputArray
                where number > 0
                select number * number;

            return positiveNumbersSquare.ToList();
        }

        public static List<int> GetSquareValueOfPositiveNumbersWithLambda(int[] inputArray)
        {
            IEnumerable<int> positiveNumbersSquare = inputArray.Where(number => number > 0).Select(number => number * number);

            return positiveNumbersSquare.ToList();
        }
    }
}

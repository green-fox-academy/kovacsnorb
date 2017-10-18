using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a LINQ Expression to get the even numbers from the following array:
            //int[] n = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };

            int[] n = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };

            List<int> myEvenNumbers = GetEvenNumbersWithQuery(n);
            List<int> myEvenNumbersLambda = GetEvenNumbersWithLambda(n);

            Console.ReadLine();
        }

        public static List<int> GetEvenNumbersWithQuery(int[] inputArray)
        {
            IEnumerable<int> evenNumbers =
                from number in inputArray
                where number % 2 == 0
                select number;

            return evenNumbers.ToList();
        }

        public static List<int> GetEvenNumbersWithLambda(int[] inputArray)
        {
            IEnumerable<int> evenNumbers = inputArray.Where(number => number % 2 == 0);
            return evenNumbers.ToList();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_04
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a LINQ Expression to find which number squared value is more then 20 from the following array:

            //int[] n = new[] { 3, 9, 2, 8, 6, 5 };

            int[] n = new[] { 3, 9, 2, 8, 6, 5 };

            List<int> myNumbers = SquaredValueIsMoreThan20WithQuery(n);
            List<int> myNumbers2 = SquaredValueIsMoreThan20WithLambda(n);
            Console.ReadLine();
        }

        public static List<int> SquaredValueIsMoreThan20WithQuery(int[] inputArray)
        {
            IEnumerable<int> myNumbers =
                from number in inputArray
                where number * number > 20
                select number;

            return myNumbers.ToList();
        }

        public static List<int> SquaredValueIsMoreThan20WithLambda(int[] inputArray)
        {
            IEnumerable<int> myNumbers = inputArray.Where(number => number * number > 20);

            return myNumbers.ToList();
        }
    }
}

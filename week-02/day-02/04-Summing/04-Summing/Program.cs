using System;

namespace _04_Summing
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Write a function called `sum` that sum all the numbers
            //   until the given parameter
            Console.Write("Give me a parameter: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(Sum(number));
            Console.ReadLine();
        }

        public static int Sum(int parameterToSum)
        {
            int sum = 0;
            for (int i = parameterToSum; i > 0; i--)
            {
                sum += i;
            }
            return sum;
        }
    }
}

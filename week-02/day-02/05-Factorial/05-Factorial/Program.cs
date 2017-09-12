using System;

namespace _05_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create a function called `factorio`
            //   that returns it's input's factorial
            Console.Write("Give me a number: ");
            double number = double.Parse(Console.ReadLine());
            Console.WriteLine(Factorio(number));
            Console.ReadLine();
        }

        public static double Factorio(double param)
        {
            double multiplied = 1;
            for (double i = param; i > 0; i--)
            {
                multiplied *= i;
            }
            return multiplied;
        }
    }
}

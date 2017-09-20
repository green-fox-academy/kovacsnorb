using System;

namespace DivideByZero
{
    class Program
    {
        static void Main(string[] args)
        {
            // create a function that takes a number
            // divides ten with it,
            // and prints the result.
            // it should print "fail" if the parameter is 0

            Console.Write("Give me a number I can divide the 10 with: ");
            try
            {
                int number = int.Parse(Console.ReadLine());
                DivideTenWith(number);
            }
            catch (FormatException e)
            {
                Console.WriteLine("wrong input data");
            }
            finally
            {
                Console.ReadLine();
            }
        }

        public static void DivideTenWith(int userInput)
        {
            try
            {
                int result = 10 / userInput;
                Console.WriteLine(result);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("fail");
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}

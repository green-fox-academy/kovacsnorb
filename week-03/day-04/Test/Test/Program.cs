using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FactorialWithLoop(10));
            Console.WriteLine(FactorialWithRecursion(10));
            Console.ReadLine();
        }

        public static int FactorialWithLoop(int n)
        {
            int factorial = 1;
            for (int i = 1; i < n + 1; i++)
            {
                factorial *= i;
            }
            return factorial;
        }

        public static int FactorialWithRecursion(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            else
            {
                return n * FactorialWithRecursion(n - 1);
            }
        }
    }
}

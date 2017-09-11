using System;

namespace _08_Swap
{
    class Program
    {
        static void Main(string[] args)
        {
            // Swap the values of the wariables
            int a = 123;
            int b = 526;
            int c = a;
            a = b;
            b = c;
            Console.WriteLine("Value of 'a' is: " + a + ", value of 'b' is: " + b);
            Console.ReadLine();
        }
    }
}

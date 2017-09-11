using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 12;
            a += 4;
            // prints 16
            Console.WriteLine(a);

            int b = 12;
            b -= 4;
            // prints 8
            Console.WriteLine(b);

            int c = 12;
            // prints 12
            Console.WriteLine(c++);
            // prints 13
            Console.WriteLine(c);

            int d = 12;
            // prints 13
            Console.WriteLine(++d);
            // prints 13
            Console.WriteLine(d);

            int e = 12;
            // prints 12
            Console.WriteLine(e--);
            // prints 11
            Console.WriteLine(e);

            int f = 12;
            // prints 11
            Console.WriteLine(--f);
            // prints 11
            Console.WriteLine(f);

            int g = 12;
            g *= 3;
            // prints 36
            Console.WriteLine(g);

            int h = 12;
            h /= 3;
            // prints 4
            Console.WriteLine(h);

            int i = 12;
            i %= 7;
            // prints 5
            Console.WriteLine(i);

            Console.ReadLine();
        }
    }
}

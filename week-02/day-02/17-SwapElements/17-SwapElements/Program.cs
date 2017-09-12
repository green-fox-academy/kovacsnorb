using System;

namespace _17_SwapElements
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create an array variable named `abc`
            //   with the following content: `["first", "second", "third"]`
            // - Swap the first and the third element of `abc`
            string[] abc = new string[3] { "first", "second", "third" };
            string temp = abc[0];
            abc[0] = abc[2];
            abc[2] = temp;

            for (int i = 0; i < abc.Length; i++)
            {
                Console.Write("{0}, ", abc[i]);
            }

            Console.ReadLine();
        }
    }
}

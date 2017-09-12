using System;

namespace _12_PrintElement
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create an array variable named `af`
            //   with the following content: `[4, 5, 6, 7]`
            // - Print all the elements of `af`
            int[] af = new int[4] { 4, 5, 6, 7 };
            for (int i = 0; i < af.Length; i++)
            {
                Console.Write("{0}, ", af[i]);
            }
            Console.ReadLine();
        }
    }
}

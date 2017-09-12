using System;

namespace _14_DoubleItems
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create an array variable named `ag`
            //   with the following content: `[3, 4, 5, 6, 7]`
            // - Double all the values in the array
            int[] ag = new int[5] { 3, 4, 5, 6, 7 };
            for (int i = 0; i < ag.Length; i++)
            {
                ag[i] = 2 * ag[i];
            }

            for (int i = 0; i < ag.Length; i++)
            {
                Console.Write("{0}, ", ag[i]);
            }
            Console.ReadLine();
        }
    }
}

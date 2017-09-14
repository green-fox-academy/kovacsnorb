using System;

namespace _19_ReverseList
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create an array variable named `aj`
            //   with the following content: `[3, 4, 5, 6, 7]`
            // - Reverse the order of the elements in `aj`
            // - Print the elements of the reversed `aj`
            int[] aj = new int[5] { 3, 4, 5, 6, 7 };
            int temp = 0;

            for (int i = 0; i < aj.Length / 2; i++)
            {
                temp = aj[i];
                aj[i] = aj[aj.Length - i - 1];
                aj[aj.Length - i - 1] = temp;
            }

            for (int i = 0; i < aj.Length; i++)
            {
                Console.Write("{0}, ", aj[i]);
            }
            
            Console.ReadLine();
        }
    }
}

﻿using System;

namespace _10_ChangeElement
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create an array variable named `s`
            //   with the following content: `[1, 2, 3, 8, 5, 6]`
            // - Change the 8 to 4
            // - Print the fourth element
            int[] s = new int[6] { 1, 2, 3, 8, 5, 6 };
            
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 8)
                    s[i] = 4;
            }
            Console.WriteLine(s[3]);
            Console.ReadLine();
        }
    }
}

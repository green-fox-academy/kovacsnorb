using System;

namespace _16_AppendA
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create an array variable named `nimals`
            //   with the following content: `["kuty", "macsk", "cic"]`
            // - Add all elements an `"a"` at the end
            string[] nimals = new string[3] { "kuty", "macsk", "cic" };
            for (int i = 0; i < nimals.Length; i++)
            {
                nimals[i] = nimals[i] + "a";
            }

            for (int i = 0; i < nimals.Length; i++)
            {
                Console.Write("{0}, " , nimals[i]);
            }
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;

namespace Lists_03
{
    class Program
    {
        static void Main(string[] args)
        {
            var far = new List<string> { "kuty", "macsk", "kacs", "rók", "halacsk" };
            // Add "a" to every string in the far list.

            for (int i = 0; i < far.Count; i++)
            {
                far[i] = far[i] + "a";
            }

            for (int i = 0; i < far.Count; i++)
            {
                Console.Write("{0}, ", far[i]);
            }
            Console.ReadLine();
        }
    }
}

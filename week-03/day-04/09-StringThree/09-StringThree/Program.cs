using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_StringThree
{
    class Program
    {
        static void Main(string[] args)
        {
            // Given a string, compute recursively a new string where all the
            // adjacent chars are now separated by a "*".

            Console.Write("Give me a string: ");
            string input = Console.ReadLine();
            int inputLength = input.Length;
            Console.WriteLine((CharacterChange(input, inputLength)));
            Console.ReadLine();
        }

        public static string CharacterChange(string input, int length)
        {
            //if (length == 0)
            //{
            //    return "*";
            //}
            //else
            //{
            //    {
            //        return CharacterChange(input, length - 1) + input.Substring(length - 1, 1) + "*";
            //    }
            //}

            return length == 0 ? "*" : CharacterChange(input, length - 1) + input.Substring(length - 1, 1) + "*";
        }
    }
}

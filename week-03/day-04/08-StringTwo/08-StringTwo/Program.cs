using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_StringTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Given a string, compute recursively a new string where all the 'x' chars have been removed.

            Console.Write("Give me a string: ");
            string input = Console.ReadLine();
            int inputLength = input.Length;
            Console.WriteLine((CharacterChange(input, inputLength)));
            Console.ReadLine();
        }

        public static string CharacterChange(string input, int length)
        {

            string result;
            if (length == 0)
            {
                return "";
            }
            else
            {
                if (input.Substring(length - 1, 1) == "x")
                {
                    result = "";

                    return CharacterChange(input, length - 1) + result;
                }
                else
                {
                    return CharacterChange(input, length - 1) + input.Substring(length - 1, 1);
                }
            }
        }
    }
}

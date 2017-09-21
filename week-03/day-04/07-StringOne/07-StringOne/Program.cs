using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_StringOne
{
    class Program
    {
        static void Main(string[] args)
        {
            // Given a string, compute recursively (no loops) a new string where all the
            // lowercase 'x' chars have been changed to 'y' chars.

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
                    result = "y";

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

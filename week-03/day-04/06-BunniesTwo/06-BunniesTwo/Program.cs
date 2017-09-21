using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_BunniesTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            // We have bunnies standing in a line, numbered 1, 2, ... The odd bunnies
            // (1, 3, ..) have the normal 2 ears. The even bunnies (2, 4, ..) we'll say
            // have 3 ears, because they each have a raised foot. Recursively return the
            // number of "ears" in the bunny line 1, 2, ... n (without loops or multiplication).

            Console.Write("How many bunnies do we have? ");
            int userInput = int.Parse(Console.ReadLine());
            Console.WriteLine(BunnyEars(userInput));
            Console.ReadLine();
        }

        public static int BunnyEars(int input)
        {
            int bunnyEars = 0;

            if (input == 0)
            {
                return 0;
            }
            else
            {
                if (input % 2 == 0)
                {
                    bunnyEars += 3;
                }
                else
                {
                    bunnyEars += 2;
                }

                return bunnyEars + BunnyEars(input - 1);
            }
        }
    }
}

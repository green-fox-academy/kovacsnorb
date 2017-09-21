using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_BunniesOne
{
    class Program
    {
        static void Main(string[] args)
        {
            // We have a number of bunnies and each bunny has two big floppy ears.
            // We want to compute the total number of ears across all the bunnies recursively (without loops or multiplication).

            Console.Write("How many bunnies do we have? ");
            int numberOfBunnies = int.Parse(Console.ReadLine());
            Console.WriteLine(BunniesOne(numberOfBunnies));
            Console.ReadLine();
        }

        public static int BunniesOne(int userInput)
        {
            if (userInput == 1)
            {
                return 2;
            }
            else
            {
                return 2 + BunniesOne(userInput - 1);
            }
        }
    }
}

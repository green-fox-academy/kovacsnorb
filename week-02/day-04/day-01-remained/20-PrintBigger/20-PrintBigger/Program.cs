using System;

namespace _20_PrintBigger
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for two numbers and prints the bigger one
            Console.Write("Give me number1: ");
            int number1 = int.Parse(Console.ReadLine());
            Console.Write("Give me number2: ");
            int number2 = int.Parse(Console.ReadLine());

            if (number1 == number2)
            {
                Console.WriteLine("The two number is equal.");
            }
            else if (number2 > number1)
            {
                Console.WriteLine("Number2 is the bigger.");
            }
            else
            {
                Console.WriteLine("Number1 is the bigger.");
            }
            Console.ReadLine();
        }
    }
}

using System;

namespace _17_AverageOfInput
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for 5 integers in a row,
            // then it should print the sum and the average of these numbers like:
            //
            // Sum: 22, Average: 4.4

            Console.Write("Give me the 1st number: ");
            int number01 = int.Parse(Console.ReadLine());
            Console.Write("Give me the 2nd number: ");
            int number02 = int.Parse(Console.ReadLine());
            Console.Write("Give me the 3rd number: ");
            int number03 = int.Parse(Console.ReadLine());
            Console.Write("Give me the 4th number: ");
            int number04 = int.Parse(Console.ReadLine());
            Console.Write("Give me the 5th number: ");
            int number05 = int.Parse(Console.ReadLine());

            int sum = number01 + number02 + number03 + number04 + number05;
            int average = sum / 5;

            Console.WriteLine("Sum: " + sum + ", Average: " + average);
            Console.ReadLine();
        }
    }
}

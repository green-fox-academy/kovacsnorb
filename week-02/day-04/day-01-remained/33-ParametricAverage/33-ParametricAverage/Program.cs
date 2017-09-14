using System;

namespace _33_ParametricAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for a number.
            // It would ask this many times to enter an integer,
            // if all the integers are entered, it should print the sum and average of these
            // integers like:
            //
            // Sum: 22, Average: 4.4
            Console.Write("Give me a number: ");
            int number = int.Parse(Console.ReadLine());

            int counter = 0;
            double sum = 0.0;

            for (int i = 0; i < number; i++)
            {
                Console.Write("Give me number " + (i+1) + ": ");
                int givenNumber = int.Parse(Console.ReadLine());
                sum += givenNumber;
                counter++;
            }
            Console.WriteLine("Sum: " + sum + ", Average: " + (sum/counter));
            Console.ReadLine();
        }
    }
}

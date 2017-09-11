using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 13;

            if (a == 13)
            {
                // this block will run
                Console.WriteLine("Yaaay! The value of the \"a\" variable is 13");
            }

            if (a == 8)
            {
                // this block will NOT run
                Console.WriteLine("Yaaay! The value of the \"a\" variable is 8");
            }


            int b = 20;

            if (b < 10)
            {
                // this block will NOT run
                Console.WriteLine("Yaaay! The value of the \"b\" variable is lower than 10");
            }
            else
            {
                // this block will run
                Console.WriteLine("Yaaay! The value of the \"b\" variable is higher than 10");
            }


            int c = 15;

            if (c < 10)
            {
                // this block will NOT run
                Console.WriteLine("Yaaay! The value of the \"b\" variable is lower than 10");
            }
            else if (c < 20)
            {
                // this block will run
                Console.WriteLine("Yaaay! The value of the \"b\" variable is higher than 10 but less then 20");
            }
            else
            {
                // this block will NOT run
                Console.WriteLine("Yaaay! The value of the \"b\" variable is higher than 10");
            }


            bool thirsty = true;
            bool hungry = false;

            if (thirsty && hungry)
            {
                Console.WriteLine("Lunch time!");
            }
            else if (thirsty || hungry)
            {
                Console.WriteLine("Snack time!");
            }
            else
            {
                Console.WriteLine("No food for you, little fatty.");
            }

            Console.ReadLine();
        }
    }
}

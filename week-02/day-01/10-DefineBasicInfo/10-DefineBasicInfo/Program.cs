using System;

namespace _10_DefineBasicInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define several things as a variable than print their values
            // Your name as a string
            // Your age as an integer
            // Your height in meters as a double
            // Wether you are married or not as a boolean
            string name = "Norbi";
            int age = 31;
            double height = 1.68;
            bool isMarried = false;
            Console.WriteLine("My name is: " + name + ", my age is: " + age + ", my height is: " + height + ", my marriage status is: " + isMarried);
            Console.ReadLine();
        }
    }
}

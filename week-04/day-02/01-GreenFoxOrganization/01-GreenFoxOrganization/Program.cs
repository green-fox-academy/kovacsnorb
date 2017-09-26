using System;

namespace _01_GreenFoxOrganization
{
    class Program
    {
        static void Main(string[] args)
        {

            var mentor = new Mentor("Olga", 43, "female", "senior");

            mentor.Introduce();

            Console.ReadLine();
        }
    }
}

using System;

namespace _01_GreenFoxOrganization
{
    class Program
    {
        static void Main(string[] args)
        {

            var sponsor = new Sponsor("Sergei", 43, "male", "Yahoo!");

            sponsor.Introduce();

            Console.ReadLine();
        }
    }
}

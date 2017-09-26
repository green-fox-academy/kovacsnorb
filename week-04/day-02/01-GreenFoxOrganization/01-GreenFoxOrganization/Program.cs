using System;

namespace _01_GreenFoxOrganization
{
    class Program
    {
        static void Main(string[] args)
        {

            Person person1 = new Person("Reka", 20, "female");

            person1.Introduce();

            Console.ReadLine();
        }
    }
}

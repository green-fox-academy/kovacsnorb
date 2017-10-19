using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a Fox class with 3 properties(name, type, color) Fill a list with at least 5 foxes, 
            //it's up to you how you name/create them! Write a LINQ Expression to find the foxes with green 
            //color! Write a LINQ Expression to find the foxes with green color and pallida type!

            var foxList = new List<Fox>();

            foxList.Add(new Fox("Vuk", "fennec", "pink"));
            foxList.Add(new Fox("Karak", "arctic", "yellow"));
            foxList.Add(new Fox("Sanyi", "pallida", "grey"));
            foxList.Add(new Fox("Joci", "pallida", "green"));
            foxList.Add(new Fox("Julika", "pallida", "green"));
            foxList.Add(new Fox("Sarkika", "pale", "green"));

            var greenFoxList = FindMyGreenFoxes(foxList);
            var greenPallidaList = FindMyGreenPallidas(foxList);

            Console.ReadLine();
        }

        public static List<Fox> FindMyGreenFoxes(List<Fox> inputList)
        {
            return inputList.Where(fox => fox.Colour == "green").ToList();
        }

        public static List<Fox> FindMyGreenPallidas(List<Fox> inputList)
        {
            return inputList.Where(fox => fox.Colour == "green" && fox.Type == "pallida").ToList();
        }
    }
}

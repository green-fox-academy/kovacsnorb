using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_08
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a LINQ Expression to find the uppercase characters in a string!

            string sampleString = "Rome lOnDon NaiRobI calIFORniA Zurich NeW DElhi amsTerdam";

            List<char> myResults = UpperCaseChars(sampleString);
            List<char> myResults2 = UpperCaseCharsWithLambda(sampleString);

            Console.ReadLine();
        }

        public static List<char> UpperCaseChars(string inputString)
        {
            var uppercaseChars =
                from betu in inputString
                where Char.IsUpper(betu)
                select betu;

            return uppercaseChars.ToList();
        }

        public static List<char> UpperCaseCharsWithLambda(string inputString)
        {
            var uppercaseChars = inputString.Where(betu => Char.IsUpper(betu)).ToList();

            return uppercaseChars;
        }
    }
}

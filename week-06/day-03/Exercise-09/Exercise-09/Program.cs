using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_09
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a LINQ Expression to convert a char array to a string!

            char[] myArray = { 'h', 'e', 'l', 'l', 'o', 'h', 'i' };

            string myOutput = ArrayToString(myArray);
            string myOutput2 = ArrayToStringWithLambda(myArray);

            Console.ReadLine();
        }

        public static string ArrayToString(char[] inputArray)
        {
            var myOutput = String.Concat(
                from chars in inputArray
                select chars);

            return myOutput;
        }

        public static string ArrayToStringWithLambda(char[] inputArray)
        {
            var myOutput = String.Concat(inputArray.Select(x => x));
 
            return myOutput.ToString();
        }
    }
}

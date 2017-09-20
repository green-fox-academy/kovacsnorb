//// create a function that takes a number
//// divides ten with it,
//// and prints the result.
//// it should print "fail" if the parameter is 0

//using System;

//namespace DailyWork
//{
//    class Program
//    {
//        //static void Main(string[] args)
//        {
//            DivideTenWith(GetDivider());
//        }
        
//        public static int GetDivider()
//        {
//            Console.WriteLine("Give me a number that I can divide 10 with: ");
//            try
//            {
//                int userInput = int.Parse(Console.ReadLine());
//            }
//            catch (FormatException e)
//            {
//                Console.WriteLine("Write an integer, please.");
//            }
//            return userInput;
//        }

//        public static void DivideTenWith(int input)
//        {
//            try
//            {
//                int output = 10 / input;
//                Console.WriteLine("The result is: " + output);
//            }
//            catch (DivideByZeroException e)
//            {
//                Console.WriteLine("Do not divide by zero.");
//            }
//            finally
//            {
//                Console.ReadLine();
//            }

//        }
//    }
//}

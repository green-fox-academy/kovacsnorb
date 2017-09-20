// Write a program that opens a file called "my-file.txt", then prints
// each of lines form the file.
// If the program is unable to read the file (for example it does not exists),
// then it should print an error message like: "Unable to read file: my-file.txt"

using System;
using System.IO;

namespace DailyWork
{
    class Program
    {
        public static void Main(string[] args)
        {
            string path = "my-file.txt";
            try
            {
                String content = File.ReadAllLines(path);
                // Prints the first line of the file
                Console.WriteLine(content[0]);
            }
            catch (Exception)
            {
                Console.WriteLine("Uh-oh, could not read the file!");
            }

            Console.ReadLine();
        }
    }
}
using System;
using System.IO;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"./lorem-ipsum.txt";
            using (StreamWriter writer = new StreamWriter(path))  
            {
                writer.WriteLine("Hello Alpaga!");
            }
        }
    }
}
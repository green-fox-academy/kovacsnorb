using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2
{
    class Program
    {
        static void Main(string[] args)
        {
            string test = "tregwwwretgetgscxwxss";
            string test2 = test.Replace('w', 'y');
            Console.WriteLine(test);
            Console.WriteLine(test2);
            Console.ReadLine();
        }
    }
}

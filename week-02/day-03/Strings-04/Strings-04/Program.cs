using System;

namespace Strings_04
{
    class Program
    {
        static void Main(string[] args)
        {
            string todoText = " - Buy milk\n";
            // Add "My todo:" to the beginning of the todoText
            // Add " - Download games" to the end of the todoText
            // Add " - Diablo" to the end of the todoText but with indention

            // Expected output:

            // My todo:
            //  - Buy milk
            //  - Download games
            //      - Diablo

            string todoPart1 = "My todo:";
            string todoPart2 = " - Download games";
            string todoPart3 = " - Diablo";

            todoText = todoPart1 + "\n" + todoText;
            todoText = todoText + todoPart2;
            todoText = todoText + "\n" + "    " + todoPart3;

            Console.WriteLine(todoText);
            Console.ReadLine();
        }
    }
}

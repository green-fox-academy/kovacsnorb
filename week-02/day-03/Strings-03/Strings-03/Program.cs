using System;
using System.Text;

namespace Strings_03
{
    class Program
    {
        static void Main(string[] args)
        {
            string quote = "Hofstadter's Law: It you expect, even when you take into account Hofstadter's Law.";

            // When saving this quote a disk error has occured. Please fix it.
            // Add "always takes longer than" to the StringBuilder (quote) between the words "It" and "you"
            // Using pieces of the quote variable (instead of just redefining the string)

            string quoteToInsert = "always takes longer than";

            string[] wordsOfQuote = quote.Split(' ');
            string[] wordsOfQuote2 = quoteToInsert.Split(' ');
            int lastWordOfFirstPart = 3;

            StringBuilder quoteFinal = new StringBuilder();

            WordsToOneLine(0, lastWordOfFirstPart, wordsOfQuote, quoteFinal);
            WordsToOneLine(0, wordsOfQuote2.Length, wordsOfQuote2, quoteFinal);
            WordsToOneLine(lastWordOfFirstPart + 1, wordsOfQuote.Length, wordsOfQuote, quoteFinal);
            Console.WriteLine(quoteFinal.ToString());
            Console.ReadLine();
        }

       public static StringBuilder WordsToOneLine(int countFrom, int countTo, string[] stringToConcatanate, StringBuilder finalLine)
               {
                   for (int i = countFrom; i < countTo; i++)
                   {
                       finalLine.Append(stringToConcatanate[i]);
                       finalLine.Append(" ");
                   }
            return finalLine;
        }

    }
}

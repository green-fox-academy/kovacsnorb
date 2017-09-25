using System;
using System.Collections.Generic;

namespace _03_Dominoes
{
    class Program
    {
        static void Main(string[] args)
        {
            var dominoes = InitializeDominoes();
            // You have the list of Dominoes
            // Order them into one snake where the adjacent dominoes have the same numbers on their adjacent sides
            // Create a function to write the dominous to the console in the following format
            // eg: [2, 4], [4, 3], [3, 5] ...

            DominoCheck(dominoes);

            Console.ReadLine();
        }

        public static List<Domino> InitializeDominoes()
        {
            var dominoes = new List<Domino>();
            dominoes.Add(new Domino(5, 2));
            dominoes.Add(new Domino(4, 6));
            dominoes.Add(new Domino(1, 5));
            dominoes.Add(new Domino(6, 7));
            dominoes.Add(new Domino(2, 4));
            dominoes.Add(new Domino(7, 1));
            return dominoes;
        }

        public static void DominoCheck(List<Domino> inputList)
        {
            int[] dom = inputList[0].GetValues();

            Console.Write("[" + dom[0] + ", " + dom[1] + "], ");

            for (int i = 0; i < inputList.Count; i++)
            {
                foreach (Domino dominoArray in inputList)
                {
                    if (dom[1] == dominoArray.GetValues()[0])
                    {
                        Console.Write("[" + dominoArray.GetValues()[0] + ", " + dominoArray.GetValues()[1] + "], ");
                        dom[0] = dominoArray.GetValues()[0];
                        dom[1] = dominoArray.GetValues()[1];
                    }
                }
            }
        }
    }
}

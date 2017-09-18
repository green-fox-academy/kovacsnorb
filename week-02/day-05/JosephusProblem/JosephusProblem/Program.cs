using System;
using System.Collections.Generic;

namespace JosephusProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many people are in the game? ");
            int numberOfPlayers = int.Parse(Console.ReadLine());
            List<int> players = new List<int>();
            List<int> players2 = new List<int>();

            for (int i = 0; i < numberOfPlayers; i++)
            {
                players.Add(i + 1);
            }

            // The elements of the list at the beginning
            //for (int i = 0; i < numberOfPlayers; i++)
            //{
            //    Console.Write(players[i]);
            //}
            //Console.WriteLine();

            do
            {
                for (int i = 0; i < players.Count; i++)
                {
                    if (i % 2 == 0)
                    {
                        players2.Add(players[i]);
                    }
                }

                int counterOfPlayers = players.Count;
                players.Clear();

                if (counterOfPlayers % 2 == 0)
                {
                    for (int i = 0; i < players2.Count; i++)
                    {
                        players.Add(players2[i]);
                    }
                }
                else
                {
                    players.Add(players2[players2.Count - 1]);
                    for (int i = 1; i < players2.Count; i++)
                    {
                        players.Add(players2[i - 1]);
                    }
                }

                players2.Clear();

                // The elements of the list after every round, taking the last one to the first place if the number of list is odd
                //for (int i = 0; i < players.Count; i++)
                //{
                //    Console.Write(players[i]);
                //}
                //Console.WriteLine();

            } while (players.Count > 1);

            for (int i = 0; i < players.Count; i++)
            {
                Console.WriteLine("The one who survives is player " + players[i] + ".");
            }            
            Console.ReadLine();
        }
    }
}

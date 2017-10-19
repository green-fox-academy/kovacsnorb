using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            var myDeck = Deck.ShuffleDeck(Deck.FillDeck());

            foreach (Card card in myDeck)
            {
                Console.WriteLine(card.Color + " " + card.Suit + " " + card.Rank);
            }

            Console.ReadLine();
        }
    }
}
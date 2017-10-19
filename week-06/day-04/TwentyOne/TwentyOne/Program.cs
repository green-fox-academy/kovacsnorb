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

            var myCard = Deck.PullFirst(myDeck);
            var myCard2 = Deck.PullLast(myDeck);
            var myCard3 = Deck.PullRandom(myDeck);

            Console.ReadLine();
        }
    }
}
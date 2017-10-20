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
            Game.OpponentScore();

            var yourCards = Game.GetInitialCards(myDeck);
            Game.WriteActualDeckAndPoints(yourCards);

            Console.ReadLine();
        }
    }
}
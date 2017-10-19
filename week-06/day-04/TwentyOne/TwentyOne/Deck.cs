using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    class Deck
    {
        public static List<Card> FillDeck()
        {
            var myDeck = new List<Card>();

            for (int i = 0; i < Enum.GetNames(typeof(Card.Colors)).Length; i++)
            {
                for (int j = 0; j < Enum.GetNames(typeof(Card.Suits)).Length; j++)
                {
                    for (int k = 0; k < Enum.GetNames(typeof(Card.Ranks)).Length; k++)
                    {
                        myDeck.Add(new Card(Card.Color = (Card.Colors)i, Card.Suit = (Card.Suits)j, Card.Rank = (Card.Ranks)k));
                    }
                }
            }

            return myDeck;
        }
    }
}

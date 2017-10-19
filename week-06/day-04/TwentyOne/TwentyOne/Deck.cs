using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    class Deck
    {
        private static readonly Random rnd = new Random();
        
        public static List<Card> FillDeck()
        {
            var myDeck = new List<Card>();

            for (int i = 0; i < Enum.GetNames(typeof(Card.Colors)).Length; i++)
            {
                for (int j = 0; j < Enum.GetNames(typeof(Card.Suits)).Length; j++)
                {
                    for (int k = 0; k < Enum.GetNames(typeof(Card.Ranks)).Length; k++)
                    {
                        var card = new Card((Card.Colors)i, (Card.Suits)j, (Card.Ranks)k);
                        myDeck.Add(card);
                    }
                }
            }

            return myDeck;
        }

        public static List<Card> ShuffleDeck(List<Card> inputDeck)
        {
            var tempCardsList = new List<Card>();
            Card cardToCheck;

            for (int i = 0; i < inputDeck.Count; i++)
            {
                tempCardsList.Add(inputDeck[i]);
            }

            inputDeck.RemoveRange(0, inputDeck.Count());

            for (int i = 0; i < tempCardsList.Count;)
            {
                cardToCheck = tempCardsList[rnd.Next(0, tempCardsList.Count)];
                if (!inputDeck.Contains(cardToCheck))
                {
                    inputDeck.Add(cardToCheck);
                    i++;
                }
            }

            return inputDeck;
        }
    }
}

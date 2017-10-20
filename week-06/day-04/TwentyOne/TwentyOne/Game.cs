using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    class Game
    {
        public static readonly Random rnd = new Random();

        public static void OpponentScore()
        {
            Console.WriteLine("Welcome to my fantastic game \"Twenty + One\"!" +
                "\n-----------------------------------" +
                "\nThe coumputer has {0} points." +
                "\n-----------------------------------", rnd.Next(15, 22));
        }

        public static List<Card> GetInitialCards(List<Card> actualdeck)
        {
            List<Card> initialCards = new List<Card>();
            initialCards.Add(Deck.PullRandom(actualdeck));
            initialCards.Add(Deck.PullRandom(actualdeck));

            return initialCards;
        }

        public static int GetPoints(List<Card> actualcards)
        {
            int points = 0;
            int temporaryPoints1 = 0;
            int temporaryPoints2 = 0;
            foreach (var card in actualcards)
            {
                string value = card.Rank.ToString();
                temporaryPoints1 = Card.cardValues[value][0];
                temporaryPoints2 = Card.cardValues[value][Card.cardValues[value].Count - 1];

                if (points + temporaryPoints2 > 21)
                {
                    points += temporaryPoints1;
                }
                else
                {
                    points += temporaryPoints2;
                }
            } 

            return points;
        }

        public static void WriteActualDeckAndPoints(List<Card> cardList)
        {
            Console.WriteLine("Your cards are: \n");
            foreach (var item in cardList)
            {
                Console.WriteLine($" [{item.Color} {item.Suit} {item.Rank}]");
            }
            Console.WriteLine("\nYour actual points are: {0} points.", Game.GetPoints(cardList));
            Console.WriteLine("-----------------------------------");
        }
    }
}

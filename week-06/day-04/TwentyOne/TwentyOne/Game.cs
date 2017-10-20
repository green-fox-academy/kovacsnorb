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
        public static List<Card> initialCards;
        public static int opponentScore = 0;
        public static readonly int MAXWINNERPOINT = 21;
        public static readonly int MINOPPONENTPOINT = 15;

        public static int OpponentScore()
        {
            return rnd.Next(MINOPPONENTPOINT, MAXWINNERPOINT + 1);
        }

        public static List<Card> GetInitialCards(List<Card> actualdeck)
        {
            initialCards = new List<Card>();
            initialCards.Add(Deck.PullRandom(actualdeck));
            initialCards.Add(Deck.PullRandom(actualdeck));

            return initialCards;
        }

        public static List<Card> GetNewCard(List<Card> actualCards, List<Card> actualDeck)
        {
            actualCards.Add(Deck.PullRandom(actualDeck));

            return actualCards;
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

                if (points + temporaryPoints1 > MAXWINNERPOINT)
                {
                    points += temporaryPoints2;
                }
                else
                {
                    points += temporaryPoints1;
                }
            } 

            return points;
        }

        public static void WriteActualDeckAndPoints(List<Card> cardList)
        {
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Your cards are: \n");
            foreach (var item in cardList)
            {
                Console.WriteLine($" [{item.Color} {item.Suit} {item.Rank}]");
            }
            Console.WriteLine("\nYour actual points are: {0} points.", Game.GetPoints(cardList));
            Console.WriteLine("-----------------------------------");
        }

        public static void InitializeCards()
        {
            Console.WriteLine($"Welcome to the fantastic game \"{MAXWINNERPOINT}\"!");

            var myDeck = Deck.ShuffleDeck(Deck.FillDeck());
            Game.OpponentScore();

            var yourCards = Game.GetInitialCards(myDeck);
            Game.WriteActualDeckAndPoints(yourCards);
        }

        public static void GameStart()
        {
            int opponentScore = OpponentScore();
            Console.WriteLine("Would you like to " +
                "\n - [H]it a new card or " +
                "\n - [S]tand at this point?");

            string userInput = Console.ReadLine().ToLower();

            if (userInput == "h")
            {
                GetNewCard(initialCards, Deck.myDeck);
                WriteActualDeckAndPoints(initialCards);

                if (Game.GetPoints(initialCards) > MAXWINNERPOINT)
                {
                    Console.WriteLine($"You lost. Your score ({Game.GetPoints(initialCards)}) is over {MAXWINNERPOINT}.");
                    RestartGame();
                }
                else
                {
                    GameStart();
                }
            }
            else if (userInput == "s")
            {
                Console.WriteLine("-----------------------------------");
                if (Game.GetPoints(initialCards) > opponentScore)
                {
                    Console.WriteLine($"You won. Your score ({Game.GetPoints(initialCards)}) is " +
                        $"higher than the computers score ({opponentScore}).");
                    RestartGame();
                }
                else if (Game.GetPoints(initialCards) == opponentScore)
                {
                    Console.WriteLine($"It is a draw. Your score ({Game.GetPoints(initialCards)}) is " +
                        $"the same as the computers score ({opponentScore}).");
                    RestartGame();
                }
                else
                {
                    Console.WriteLine($"You lost. Your score ({Game.GetPoints(initialCards)}) is " +
                        $"lower than the computers score ({opponentScore}).");
                    RestartGame();
                }
            }
            else
            {
                Console.WriteLine("----------------------------------- \nPlease, press D or F.\n");
                GameStart();
            }
        }

        public static void RestartGame()
        {
            Console.WriteLine("\nWould you like to play again? [Y]es / [N]o.");
            string userNewGame = Console.ReadLine().ToLower();

            if (userNewGame == "y")
            {
                InitializeCards();
                GameStart();
            }
            else if (userNewGame != "n")
            {
                Console.WriteLine("----------------------------------- " +
                    "\nPlease, press Y or N.\n");
                RestartGame();
            }
        }
    }
}

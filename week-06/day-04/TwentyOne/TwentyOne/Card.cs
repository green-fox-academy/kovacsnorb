using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    class Card
    {
        private static readonly Random rnd = new Random();

        public Colors Color { get; set; }
        public Suits Suit { get; set; }
        public Ranks Rank { get; set; }

        public Card(Colors color, Suits suit, Ranks rank)
        {
            Color = color;
            Suit = suit;
            Rank = rank;
        }

        public enum Colors
        {
            Red,
            Black
        }

        public enum Suits
        {
            Clubs,
            Diamonds,
            Hearts,
            Spades
        }

        public enum Ranks
        {
            Two,
            Three,
            Four,
            Five,
            Six,
            Seven,
            Eight,
            Nine,
            Ten,
            Jack,
            Queen,
            King,
            Ace
        }

        public static Dictionary<string, List<int>> cardValues = new Dictionary<string, List<int>>()
        {
            { "Two", new List<int> {2} },
            { "Three", new List<int> {3} },
            { "Four", new List<int> {4} },
            { "Five", new List<int> {5} },
            { "Six", new List<int> {6} },
            { "Seven", new List<int> {7} },
            { "Eight", new List<int> {8} },
            { "Nine", new List<int> {9} },
            { "Ten", new List<int> {10} },
            { "Jack", new List<int> {10} },
            { "Queen", new List<int> {10} },
            { "King", new List<int> {10} },
            { "Ace", new List<int> {11, 1} },
        };

    }
}

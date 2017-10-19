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
    }
}

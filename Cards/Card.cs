using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cards
{
    public enum Suit {
        club,
        diamond,
        heart,
        spade
    }
    public class Card : IEquatable<Card>
    {
        private int rank;
        private Suit suit;

        public int Rank {
            get { return rank; }
            set { if (value > 5 && value < 15) rank = value; }
        }
        public Suit Suit {
            get { return suit; }
            set { suit = value; }
        }

        public Card(int r, Suit s) {
            if (r > 5 && r < 15) rank = r;
            else Console.WriteLine("Card rank must be in the range of [6,14]");
            suit = s;
        }

        public Card()
        {
        }

        public bool Equals(Card other)
        {
            return (rank == other.Rank && suit == other.Suit);
        }
        public override bool Equals(Object obj) {
            Card c = obj as Card;
            return (c.rank == rank && c.suit == suit);
        }
        public override string ToString()
        {
            return suit.ToString() + " " + rank.ToString();
        }
    }
}

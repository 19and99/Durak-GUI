using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cards
{
    public class Player
    {
        private Deck deck;
        public Deck Deck { get { return deck; } set { deck = value; } }

        public Player( Deck d)
        {
            deck = d;
        }

        public Player()
        {
            deck = new Deck();
        }
    }
}

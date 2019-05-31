using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Cards
{
    public enum SortingTypes {
        ByRank,
        BySuit
    }
    public class Deck:IEnumerable
    {
        private List<Card> cards = new List<Card>();
        public List<Card> Cards { get { return cards; } set { cards = value; } }

        public IEnumerator GetEnumerator()
        {
           return cards.GetEnumerator();
        }
        public void AddCard(Card c) {
            if (!cards.Contains(c)) cards.Add(c);
        }
        public void AddCard(int r, Suit s) {
            if (r > 5 && r < 15) {
                Card c = new Card(r, s);
                AddCard(c);
            }
            else Console.WriteLine("Added card rank must be in the range of [6,14]");
        }
        public void AddDeck(Deck d) {
            foreach (Card c in d.cards) {
                cards.Add(c);
            }
        }
        public void Sort(SortingTypes s) {
            if (s == SortingTypes.ByRank)
            {
                cards.Sort(new SortByRank());
            }
            else
            {
                cards.Sort(new SortBySuit());
            }
        }
        public void shuffle() {
            int count = cards.Count;
            List<Card> shuffled = new List<Card>(count);
            Random random = new Random();
            for (int i = 0; i < count; ++i) {
                int index = random.Next(0, cards.Count);
                shuffled.Add(cards[index]);
                cards.RemoveAt(index);
            }
            cards = shuffled;
        }

        public void Deliver(Deck p1, Deck p2) {
            int count1 = 6 - p1.cards.Count;
            int count2 = 6 - p2.cards.Count;
            if (count1 > 0)
            {
                for (int i = 0; i < count1; ++i)
                {
                    if (cards.Count > 0)
                    {
                        p1.AddCard(cards[cards.Count - 1]);
                        cards.RemoveAt(cards.Count - 1);
                    }
                }
            }
            if (count2 > 0)
            {
                for (int i = 0; i < count2; ++i)
                {
                    if (cards.Count > 0)
                    {
                        p2.AddCard(cards[cards.Count - 1]);
                        cards.RemoveAt(cards.Count - 1);
                    }
                }
            }
        }
        public Card minCard() {
            if (cards.Count == 0) return null;
            Card c = cards[0];
            for (int i = 1; i < cards.Count; ++i) {
                if (cards[i].Rank < c.Rank) c = cards[i];
            }
            return c;
        }
        public bool HasRank(int r) {
            foreach (Card c in cards) {
                if (c.Rank == r) return true;
            }
            return false;
        }
        public Card GetMinimumSuit(Suit s) {
            Card ret = new Card();
            int min = 0;
            foreach (Card c in cards) {
                if (c.Suit == s) { ret = c; min = c.Rank; break; }
            }
            foreach (Card c in cards) {
                if (c.Suit == s && c.Rank < min) {
                    ret = c;
                    min = c.Rank;
                }
            }
            if (min == 0) return null;
            return ret;
        }
        public Card GetCover(Card card, Suit kozr) {
            Card ret = new Card();
            int min = card.Rank;
            foreach (Card c in cards)
            {
                if (c.Suit == card.Suit && c.Rank > card.Rank) { ret = c; min = c.Rank; break; }
            }
            foreach (Card c in cards)
            {
                if (c.Suit == card.Suit && c.Rank  > card.Rank && c.Rank < min)
                {
                    ret = c;
                    min = c.Rank;
                }
            }
            if (card.Suit == kozr) return null;
            else if (min == card.Rank) {
                ret = GetMinimumSuit(kozr);
                if (ret == null) return null; 
            }
            return ret;
        }
        public void Remove(Card c) {
            cards.Remove(c);
        }
        public void Clear() {
            cards.Clear();
        }
    }
}

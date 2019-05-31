using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Cards
{
    public class SortBySuit : IComparer<Card>
    {
        public int Compare(Card x, Card y)
        {
            return x.Suit.CompareTo(y.Suit);
        }
    }
    public class SortByRank : IComparer<Card>
    {
        public int Compare(Card x, Card y)
        {
            return x.Rank.CompareTo(y.Rank);
        }
    }
}

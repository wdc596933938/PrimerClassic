using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CardLib
{
    public class Card
    {
        public readonly Rank rank;
        public readonly Suit suit;

        private Card()
        {
            
        }

        public Card(Suit newSuit, Rank newRank)
        {
            rank = newRank;
            suit = newSuit;
        }

        public String ToString()
        {
            return suit + " " + rank;
        }
    }
}
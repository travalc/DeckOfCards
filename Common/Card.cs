using System;

namespace DeckOfCards
{
    public abstract class Card
    {
        public Ranks Rank { get; set; }
        public Suits Suit { get; set; }
        public int Val { get; set; }

        protected Card(Ranks rank, Suits suit)
        {
            Rank = rank;
            Suit = suit;

            CalculateVal();
        }

        public virtual void CalculateVal()
        {

        }
    }
}
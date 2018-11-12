using System;
using System.Collections.Generic;

namespace DeckOfCards
{
    public abstract class Deck
    {
        public List<Card> Cards { private get; set;}

        protected Deck()
        {
            Create();
        }

        public virtual void Create()
        {
            
        }
    }
}
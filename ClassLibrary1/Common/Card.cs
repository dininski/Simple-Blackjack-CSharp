using System;

namespace Blackjack.Common
{
    public struct Card
    {
        private CardSuit suit;
        private CardValue value;

        public CardSuit Suit
        {
            get
            {
                return this.suit;
            }
        }

        public CardValue Value
        {
            get
            {
                return this.value;
            }
        }

        public Card(CardSuit suit, CardValue value)
            : this()
        {
            this.suit = suit;
            this.value = value;
        }

        public override string ToString()
        {
            return string.Format("Suit: {0}, Value: {1}", this.suit, this.value);
        }
        
    }
}

using Blackjack.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blackjack.Players
{
    public class Player
    {
        private List<Card> hand = new List<Card>();
        private int myScore;

        public void HitMe(Card dealtCard)
        {
            hand.Add(dealtCard);
        }

        public List<Card> ShowHand()
        {
            return hand;
        }

        public string ShoutHand()
        {
            StringBuilder handString = new StringBuilder();
            foreach (Card card in hand)
            {
                handString.AppendLine(card.Suit.ToString() + ' ' + card.Value.ToString());
            }
            return handString.ToString();
        }
    }
}
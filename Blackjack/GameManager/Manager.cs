using System;
using Blackjack.Common;
using Blackjack.Players;
using System.Collections.Generic;
using System.Text;

//public static delegate int GetScore(List<Card> cards);

namespace Blackjack.GameManager
{
    public class Manager
    {
        private Deck playingDeck = new Deck();
        private List<Player> players = new List<Player>();
        private List<int> playerScores = new List<int>();
        private Player dealer = new Player();
        public bool Playing { get; set; }

        public Card DealerVisibleCard
        {
            get
            {
                return dealer.ShowHand()[0];
            }
        }

        public Card DealerLastCard
        {
            get
            {
                return dealer.ShowHand()[dealer.ShowHand().Count-1];
            }
        }

        public List<Card> getDealerCards()
        {
            return dealer.ShowHand();
        }

        public Manager()
        {
            Playing = false;
        }

        public Manager(Player player1)
        {
            players.Add(player1);
        }

        //public Manager(Player player1, Player player2)
        //    : this(player1)
        //{
        //    players.Add(player2);
        //}

        //public Manager(Player player1, Player player2, Player player3)
        //    : this(player1, player2)
        //{
        //    players.Add(player3);
        //}

        //public Manager(Player player1, Player player2, Player player3, Player player4)
        //    : this(player1, player2, player3)
        //{
        //    players.Add(player4);
        //}

        public void AddPlayer(Player newPlayer)
        {
            players.Add(newPlayer);
        }

        public void DealFirstTwoCards()
        {
            playingDeck.Shuffle();

            dealer.HitMe(playingDeck.DealCard());
            dealer.HitMe(playingDeck.DealCard());

            for (int i = 0; i < players.Count; i++)
            {
                players[i].HitMe(playingDeck.DealCard());
                players[i].HitMe(playingDeck.DealCard());
            }
        }

        public Card DealCard()
        {
            return playingDeck.DealCard();
        }

        public void StartNewDeal()
        {
            playingDeck = new Deck();
            for (int i = 0; i < players.Count; i++)
            {
                players[i].ThrowCards();
                dealer.ThrowCards();
            }
            DealFirstTwoCards();
        }

        private int GetHandScore(List<Card> cards)
        {
            int score = 0;
            for (int i = 0; i < cards.Count; i++)
            {
                int cardValue = (int)cards[i].Value;
                if (cardValue > 10)
                {
                    cardValue = 10;
                }
                score += cardValue;
            }

            if (score > 21)
            {
                score = -1;
            }

            //Blackjack returns 0
            if (cards.Count == 2 && ((cards[0].Value == CardValue.Ace && (int)cards[1].Value >= 10) || (cards[1].Value == CardValue.Ace && (int)cards[0].Value >= 10)))
            {
                return 0;
            }

            return score;
        }

        public string DisplayScores()
        {
            StringBuilder showScores = new StringBuilder();
            for (int i = 0; i < players.Count; i++)
            {
                showScores.AppendLine(String.Format("Player {0} score: {1}", i, playerScores[i]));
            }
            return showScores.ToString();
        }

        public void GiveDealerACard()
        {
            dealer.HitMe(playingDeck.DealCard());
        }

        public int GetDealerScore()
        {
            return dealer.GetScore();
        }
    }
}

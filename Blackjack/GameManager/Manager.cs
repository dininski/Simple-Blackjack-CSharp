using System;
using Blackjack.Common;
using Blackjack.Players;
using System.Collections.Generic;
using System.Text;

namespace Blackjack.GameManager
{
    public class Manager
    {
        private Deck playingDeck = new Deck();
        private List<Player> players = new List<Player>();
        private List<int> playerScores = new List<int>();

        private Player dealer = new Player();
        public bool Playing { get; set; }
        //show only one of the dealer's cards
        public Card DealerVisibleCard
        {
            get
            {
                return dealer.ShowHand()[0];
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
            playerScores.Add(0);
        }

        public Manager(Player player1, Player player2)
            : this(player1)
        {
            players.Add(player2);
            playerScores.Add(0);
        }

        public Manager(Player player1, Player player2, Player player3)
            : this(player1, player2)
        {
            players.Add(player3);
            playerScores.Add(0);
        }

        public Manager(Player player1, Player player2, Player player3, Player player4)
            : this(player1, player2, player3)
        {
            players.Add(player4);
            playerScores.Add(0);
        }

        public void AddPlayer(Player newPlayer)
        {
            players.Add(newPlayer);
            playerScores.Add(0);
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

            return score;
        }

        public void CalculateScores()
        {
            for (int i = 0; i < players.Count; i++)
            {
                List<Card> currentPlayerHand = players[i].ShowHand();
                playerScores[i] = GetHandScore(currentPlayerHand);
            }
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

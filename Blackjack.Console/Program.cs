using Blackjack.Common;
using Blackjack.GameManager;
using Blackjack.Players;
using System;

namespace Blackjack.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Player[] players = new Player[4];
            for (int i = 0; i < players.Length; i++)
            {
                players[i] = new Player();
            }

            Manager manager = new Manager();
            for (int i = 0; i < players.Length; i++)
            {
                manager.AddPlayer(players[i]);
            }

            manager.DealFirstTwoCards();
            
            for (int i = 0; i < players.Length; i++)
            {
                players[i].HitMe(manager.DealCard());
            }

            foreach (Player player in players)
            {
                System.Console.WriteLine(player.ShoutHand());
            }

            manager.CalculateScores();
            System.Console.WriteLine(manager.DisplayScores());
        }
    }
}

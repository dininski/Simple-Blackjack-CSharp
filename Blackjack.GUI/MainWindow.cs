using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Blackjack.Common;
using Blackjack.GameManager;
using Blackjack.Players;

namespace Blackjack.GUI
{
    public partial class Blackjack : Form
    {
        public Player player;
        public Manager gm;
        private int cardXPos = 44;
        public List<PictureBox> displayCards;

        public Blackjack()
        {
            InitializeComponent();
            gm = new Manager();
            player = new Player();
            gm.AddPlayer(player);
            displayCards = new List<PictureBox>();
        }

        private void standButton_Click(object sender, EventArgs e)
        {
            gm.CalculateScores();
            dealerScore.Text = "Dealer score: " + gm.GetDealerScore();

            //TODO pause for 0.5 seconds so that the user can see the dealer getting cards
            while (gm.GetDealerScore() < 17)
            {
                gm.GiveDealerACard();
                dealerScore.Text = "Dealer score: " + gm.GetDealerScore();
            }
            if (gm.GetDealerScore() > player.GetScore() && gm.GetDealerScore() < 22)
            {
                resultLabel.Text = "Dealer wins!";
            }
            else
            {
                resultLabel.Text = "Player wins!";
            }
        }

        private void hitMeButton_Click(object sender, EventArgs e)
        {

            if (!player.Busted)
            {
                player.HitMe(gm.DealCard());
                playerScore.Text = "Score: " + player.GetScore();
                cardXPos += 39;
                Card card = player.LastCard();
                PictureBox newCard = new PictureBox();
                Image img = Image.FromFile("../../card_images/" + card.Value + card.Suit + ".png");
                newCard.Image = img;
                newCard.Location = new System.Drawing.Point(cardXPos, 180);
                newCard.Name = "newCard";
                newCard.Size = new System.Drawing.Size(72, 99);
                this.Controls.Add(newCard);
                displayCards.Add(newCard);

                if (player.Busted)
                {
                    hitMeButton.Enabled = false;
                    standButton.Enabled = false;
                    splitButton.Enabled = false;
                    resultLabel.Text = "Dealer wins!";
                }
            }
        }

        private void Blackjack_Load(object sender, EventArgs e)
        {

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            resultLabel.Text = "";
            hitMeButton.Enabled = true;
            standButton.Enabled = true;
            foreach (PictureBox box in displayCards)
            {
                this.Controls.Remove(box);
            }
            cardXPos = 44;
            List<Card> playerCards = player.ShowHand();
            gm.StartNewDeal();
            playerScore.Text = "Score: " + player.GetScore();
            dealerScore.Text = "";
            FirstCard.Image = Image.FromFile("../../card_images/" + playerCards[0].Value + playerCards[0].Suit + ".png");
            secondCard.Image = Image.FromFile("../../card_images/" + playerCards[1].Value + playerCards[1].Suit + ".png");
            dealerVisibleCard.Image = Image.FromFile("../../card_images/" + gm.DealerVisibleCard.Value + gm.DealerVisibleCard.Suit + ".png");
            
            if (playerCards[0].Value == playerCards[1].Value)
            {
                splitButton.Enabled = true ;
            }
            if (player.GetScore() == 21)
            {
                resultLabel.Text = "Blackjack! Player wins!";
            }
        }

        private void FirstCard_Click(object sender, EventArgs e)
        {

        }

        private void SecondCard_Click(object sender, EventArgs e)
        {

        }
    }
}

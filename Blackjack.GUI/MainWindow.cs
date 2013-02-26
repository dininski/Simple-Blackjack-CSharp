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

        public Blackjack()
        {
            InitializeComponent();
            gm = new Manager();
            player = new Player();
            gm.AddPlayer(player);
        }

        private void standButton_Click(object sender, EventArgs e)
        {
            gm.CalculateScores();
            dealerScore.Text = "Dealer score: "+gm.GetDealerScore();
        }

        private void hitMeButton_Click(object sender, EventArgs e)
        {
            statusBox.Clear();
            player.HitMe(gm.DealCard());
            playerScore.Text = "Score: " + player.GetScore();
            foreach (Card card in player.ShowHand())
            {
                PictureBox newCard = new PictureBox();
                Image img = Image.FromFile("../../card_images/" + card.Value + card.Suit + ".png");
                newCard.Image = img;
                newCard.Location = new System.Drawing.Point(15, 422);
                newCard.Name = "newCard";
                newCard.Size = new System.Drawing.Size(72, 99);
                newCard.TabIndex = 0;
                newCard.TabStop = false;
                this.Controls.Add(newCard);
            }

            foreach (Card card in player.ShowHand())
            {
                statusBox.AppendText(String.Format(card.ToString()+"\n"));
            }
            

        }

        private void Blackjack_Load(object sender, EventArgs e)
        {

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            List<Card> playerCards = player.ShowHand();
            gm.StartNewDeal();
            playerScore.Text = "Score: " + player.GetScore();
            dealerScore.Text = "";
            FirstCard.Image = Image.FromFile("../../card_images/" + playerCards[0].Value + playerCards[0].Suit + ".png");
            SecondCard.Image = Image.FromFile("../../card_images/" + playerCards[1].Value + playerCards[1].Suit + ".png");
            dealerVisibleCard.Image = Image.FromFile("../../card_images/" + gm.DealerVisibleCard.Value + gm.DealerVisibleCard.Suit + ".png");

            this.statusBox.Clear();
            foreach (Card card in player.ShowHand())
            {
                this.statusBox.AppendText(String.Format(card.ToString()+"\n"));
            }
        }
    }
}

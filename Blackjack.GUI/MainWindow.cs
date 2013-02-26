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
        private static int startXPos = -10;
        private static int dealerStartXPos = 285;
        private int playerCardXPos = startXPos;
        private int dealerCardXPos = dealerStartXPos;
        public List<PictureBox> playerCardsToDisplay;
        public List<PictureBox> dealerCards;


        public Blackjack()
        {
            InitializeComponent();
            gm = new Manager();
            player = new Player();
            gm.AddPlayer(player);
            playerCardsToDisplay = new List<PictureBox>();
            dealerCards = new List<PictureBox>();

            splitButton.Hide();
        }

        private void DrawPlayerCard(Card card)
        {
            playerCardXPos += 30;
            PictureBox newCard = new PictureBox();
            Image img = Image.FromFile("../../card_images/" + card.Value + card.Suit + ".png");
            newCard.Image = img;
            newCard.Location = new System.Drawing.Point(playerCardXPos, 180);
            newCard.Name = "newCard";
            newCard.Size = new System.Drawing.Size(72, 99);
            this.Controls.Add(newCard);
            newCard.BringToFront();
            playerCardsToDisplay.Add(newCard);
        }

        private void DrawDealerCardNotShown(Card card)
        {

            dealerCardXPos -= 30;
            PictureBox blankCard = new PictureBox();
            Image blankImage = Image.FromFile("../../card_images/b1fv.png");
            blankCard.Image = blankImage;
            blankCard.Location = new System.Drawing.Point(dealerCardXPos, 12);
            blankCard.Name = "newCard";
            blankCard.Size = new System.Drawing.Size(72, 99);
            this.Controls.Add(blankCard);
            blankCard.BringToFront();
            dealerCards.Add(blankCard);
            
            DrawDealer(card);

        }

        private void DrawDealer(Card card)
        {
            dealerCardXPos -= 30;
            PictureBox newCard = new PictureBox();
            Image img = Image.FromFile("../../card_images/" + card.Value + card.Suit + ".png");
            newCard.Image = img;
            newCard.Location = new System.Drawing.Point(dealerCardXPos, 12);
            newCard.Name = "newCard";
            newCard.Size = new System.Drawing.Size(72, 99);
            this.Controls.Add(newCard);
            dealerCards.Add(newCard);
        }

        private void standButton_Click(object sender, EventArgs e)
        {
            dealerScore.Text = "Dealer score: " + gm.GetDealerScore();
            dealerCardXPos = dealerStartXPos;
            RemoveCards(dealerCards);
            DrawDealer(gm.getDealerCards()[1]);
            DrawDealer(gm.getDealerCards()[0]);
                
            //TODO pause for 0.5 seconds so that the user can see the dealer getting cards
            while (gm.GetDealerScore() < 17)
            {
                //System.Windows.Forms.Timer myTimer = new Timer();
                //myTimer.Tick += new EventHandler(gm.GiveDealerACard(object obj, EventArgs e));
                gm.GiveDealerACard();
                dealerScore.Text = "Dealer score: " + gm.GetDealerScore();
                DrawDealer(gm.DealerLastCard);
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
                DrawPlayerCard(player.LastCard());

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
            RemoveCards(playerCardsToDisplay);
            RemoveCards(dealerCards);

            dealerCardXPos = dealerStartXPos;
            playerCardXPos = startXPos;
            List<Card> playerCards = player.ShowHand();
            gm.StartNewDeal();
            playerScore.Text = "Score: " + player.GetScore();
            dealerScore.Text = "";
            DrawPlayerCard(playerCards[0]);
            DrawPlayerCard(playerCards[1]);
            DrawDealerCardNotShown(gm.DealerVisibleCard);

            if (playerCards[0].Value == playerCards[1].Value)
            {
                splitButton.Enabled = true;
            }
            if (player.GetScore() == 21)
            {
                resultLabel.Text = "Blackjack! Player wins!";
                hitMeButton.Enabled = false;
                standButton.Enabled = false;
            }
        }

        private void RemoveCards(List<PictureBox> cardImages)
        {
            foreach (PictureBox box in cardImages)
            {
                this.Controls.Remove(box);
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

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
            gm.DealFirstTwoCards();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            gm.CalculateScores();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Card card in player.ShowHand())
            {
                PictureBox newCard = new PictureBox();
                Image img = Image.FromFile("../../card_images/" + card.Value + card.Suit + ".png");

            }
            player.HitMe(gm.DealCard());
            

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

    }
}

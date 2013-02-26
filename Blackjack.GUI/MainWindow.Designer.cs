namespace Blackjack.GUI
{
    partial class Blackjack
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Blackjack));
            this.hitMeButton = new System.Windows.Forms.Button();
            this.standButton = new System.Windows.Forms.Button();
            this.splitButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.playerScore = new System.Windows.Forms.Label();
            this.secondCard = new System.Windows.Forms.PictureBox();
            this.FirstCard = new System.Windows.Forms.PictureBox();
            this.dealerInisibleCard = new System.Windows.Forms.PictureBox();
            this.dealerVisibleCard = new System.Windows.Forms.PictureBox();
            this.dealerScore = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.secondCard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FirstCard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealerInisibleCard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealerVisibleCard)).BeginInit();
            this.SuspendLayout();
            // 
            // hitMeButton
            // 
            this.hitMeButton.Enabled = false;
            this.hitMeButton.Location = new System.Drawing.Point(98, 285);
            this.hitMeButton.Name = "hitMeButton";
            this.hitMeButton.Size = new System.Drawing.Size(75, 23);
            this.hitMeButton.TabIndex = 0;
            this.hitMeButton.Text = "Hit Me";
            this.hitMeButton.UseVisualStyleBackColor = true;
            this.hitMeButton.Click += new System.EventHandler(this.hitMeButton_Click);
            // 
            // standButton
            // 
            this.standButton.Enabled = false;
            this.standButton.Location = new System.Drawing.Point(179, 285);
            this.standButton.Name = "standButton";
            this.standButton.Size = new System.Drawing.Size(75, 23);
            this.standButton.TabIndex = 1;
            this.standButton.Text = "Stand";
            this.standButton.UseVisualStyleBackColor = true;
            this.standButton.Click += new System.EventHandler(this.standButton_Click);
            // 
            // splitButton
            // 
            this.splitButton.Enabled = false;
            this.splitButton.Location = new System.Drawing.Point(260, 285);
            this.splitButton.Name = "splitButton";
            this.splitButton.Size = new System.Drawing.Size(75, 23);
            this.splitButton.TabIndex = 2;
            this.splitButton.Text = "Split";
            this.splitButton.UseVisualStyleBackColor = true;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(17, 285);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 3;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // playerScore
            // 
            this.playerScore.AutoSize = true;
            this.playerScore.Location = new System.Drawing.Point(209, 143);
            this.playerScore.Name = "playerScore";
            this.playerScore.Size = new System.Drawing.Size(41, 13);
            this.playerScore.TabIndex = 6;
            this.playerScore.Text = "Score: ";
            // 
            // secondCard
            // 
            this.secondCard.Image = ((System.Drawing.Image)(resources.GetObject("secondCard.Image")));
            this.secondCard.InitialImage = ((System.Drawing.Image)(resources.GetObject("secondCard.InitialImage")));
            this.secondCard.Location = new System.Drawing.Point(49, 180);
            this.secondCard.Name = "secondCard";
            this.secondCard.Size = new System.Drawing.Size(72, 99);
            this.secondCard.TabIndex = 1;
            this.secondCard.TabStop = false;
            this.secondCard.Click += new System.EventHandler(this.SecondCard_Click);
            // 
            // FirstCard
            // 
            this.FirstCard.Image = ((System.Drawing.Image)(resources.GetObject("FirstCard.Image")));
            this.FirstCard.InitialImage = ((System.Drawing.Image)(resources.GetObject("FirstCard.InitialImage")));
            this.FirstCard.Location = new System.Drawing.Point(20, 180);
            this.FirstCard.Name = "FirstCard";
            this.FirstCard.Size = new System.Drawing.Size(72, 99);
            this.FirstCard.TabIndex = 0;
            this.FirstCard.TabStop = false;
            this.FirstCard.Click += new System.EventHandler(this.FirstCard_Click);
            // 
            // dealerInisibleCard
            // 
            this.dealerInisibleCard.Image = ((System.Drawing.Image)(resources.GetObject("dealerInisibleCard.Image")));
            this.dealerInisibleCard.InitialImage = ((System.Drawing.Image)(resources.GetObject("dealerInisibleCard.InitialImage")));
            this.dealerInisibleCard.Location = new System.Drawing.Point(255, 12);
            this.dealerInisibleCard.Name = "dealerInisibleCard";
            this.dealerInisibleCard.Size = new System.Drawing.Size(72, 99);
            this.dealerInisibleCard.TabIndex = 7;
            this.dealerInisibleCard.TabStop = false;
            // 
            // dealerVisibleCard
            // 
            this.dealerVisibleCard.Image = ((System.Drawing.Image)(resources.GetObject("dealerVisibleCard.Image")));
            this.dealerVisibleCard.InitialImage = ((System.Drawing.Image)(resources.GetObject("dealerVisibleCard.InitialImage")));
            this.dealerVisibleCard.Location = new System.Drawing.Point(227, 12);
            this.dealerVisibleCard.Name = "dealerVisibleCard";
            this.dealerVisibleCard.Size = new System.Drawing.Size(72, 99);
            this.dealerVisibleCard.TabIndex = 8;
            this.dealerVisibleCard.TabStop = false;
            // 
            // dealerScore
            // 
            this.dealerScore.AutoSize = true;
            this.dealerScore.Location = new System.Drawing.Point(15, 13);
            this.dealerScore.Name = "dealerScore";
            this.dealerScore.Size = new System.Drawing.Size(0, 13);
            this.dealerScore.TabIndex = 9;
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(121, 144);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(0, 13);
            this.resultLabel.TabIndex = 10;
            // 
            // Blackjack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(352, 317);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.dealerScore);
            this.Controls.Add(this.dealerVisibleCard);
            this.Controls.Add(this.dealerInisibleCard);
            this.Controls.Add(this.secondCard);
            this.Controls.Add(this.FirstCard);
            this.Controls.Add(this.playerScore);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.splitButton);
            this.Controls.Add(this.standButton);
            this.Controls.Add(this.hitMeButton);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Blackjack";
            this.Text = "Vasil\'s Blackjack";
            this.Load += new System.EventHandler(this.Blackjack_Load);
            ((System.ComponentModel.ISupportInitialize)(this.secondCard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FirstCard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealerInisibleCard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealerVisibleCard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button hitMeButton;
        private System.Windows.Forms.Button standButton;
        private System.Windows.Forms.Button splitButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label playerScore;
        private System.Windows.Forms.PictureBox secondCard;
        private System.Windows.Forms.PictureBox FirstCard;
        private System.Windows.Forms.PictureBox dealerInisibleCard;
        private System.Windows.Forms.PictureBox dealerVisibleCard;
        private System.Windows.Forms.Label dealerScore;
        private System.Windows.Forms.Label resultLabel;
    }
}


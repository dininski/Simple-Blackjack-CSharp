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
            this.doubleButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // hitMeButton
            // 
            this.hitMeButton.Location = new System.Drawing.Point(220, 350);
            this.hitMeButton.Name = "hitMeButton";
            this.hitMeButton.Size = new System.Drawing.Size(75, 23);
            this.hitMeButton.TabIndex = 0;
            this.hitMeButton.Text = "Hit Me";
            this.hitMeButton.UseVisualStyleBackColor = true;
            this.hitMeButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // standButton
            // 
            this.standButton.Location = new System.Drawing.Point(301, 350);
            this.standButton.Name = "standButton";
            this.standButton.Size = new System.Drawing.Size(75, 23);
            this.standButton.TabIndex = 1;
            this.standButton.Text = "Stand";
            this.standButton.UseVisualStyleBackColor = true;
            this.standButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // splitButton
            // 
            this.splitButton.Location = new System.Drawing.Point(382, 350);
            this.splitButton.Name = "splitButton";
            this.splitButton.Size = new System.Drawing.Size(75, 23);
            this.splitButton.TabIndex = 2;
            this.splitButton.Text = "Split";
            this.splitButton.UseVisualStyleBackColor = true;
            // 
            // doubleButton
            // 
            this.doubleButton.Location = new System.Drawing.Point(463, 350);
            this.doubleButton.Name = "doubleButton";
            this.doubleButton.Size = new System.Drawing.Size(75, 23);
            this.doubleButton.TabIndex = 3;
            this.doubleButton.Text = "Double";
            this.doubleButton.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.pictureBox1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(220, 201);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(318, 120);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(315, 117);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Blackjack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 385);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.doubleButton);
            this.Controls.Add(this.splitButton);
            this.Controls.Add(this.standButton);
            this.Controls.Add(this.hitMeButton);
            this.Name = "Blackjack";
            this.Text = "Form1";
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button hitMeButton;
        private System.Windows.Forms.Button standButton;
        private System.Windows.Forms.Button splitButton;
        private System.Windows.Forms.Button doubleButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


namespace DogRaceBetting
{
    partial class Form1
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
        public void InitializeComponent()
        {
            this.player1Bet = new System.Windows.Forms.ComboBox();
            this.player2Bet = new System.Windows.Forms.ComboBox();
            this.player3Bet = new System.Windows.Forms.ComboBox();
            this.RaceButton = new System.Windows.Forms.Button();
            this.dog1Label = new System.Windows.Forms.Label();
            this.dog2Label = new System.Windows.Forms.Label();
            this.dog3Label = new System.Windows.Forms.Label();
            this.dog6Label = new System.Windows.Forms.Label();
            this.dog5Label = new System.Windows.Forms.Label();
            this.dog4Label = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.progressBar4 = new System.Windows.Forms.ProgressBar();
            this.progressBar5 = new System.Windows.Forms.ProgressBar();
            this.progressBar6 = new System.Windows.Forms.ProgressBar();
            this.dog6Result = new System.Windows.Forms.Label();
            this.dog5Result = new System.Windows.Forms.Label();
            this.dog4Result = new System.Windows.Forms.Label();
            this.dog3Result = new System.Windows.Forms.Label();
            this.dog2Result = new System.Windows.Forms.Label();
            this.dog1Result = new System.Windows.Forms.Label();
            this.Player1Label = new System.Windows.Forms.Label();
            this.Player2Label = new System.Windows.Forms.Label();
            this.Player3Label = new System.Windows.Forms.Label();
            this.Player3CashLabel = new System.Windows.Forms.Label();
            this.Player2CashLabel = new System.Windows.Forms.Label();
            this.Player1CashLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // player1Bet
            // 
            this.player1Bet.AllowDrop = true;
            this.player1Bet.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.player1Bet.FormattingEnabled = true;
            this.player1Bet.Location = new System.Drawing.Point(116, 13);
            this.player1Bet.Name = "player1Bet";
            this.player1Bet.Size = new System.Drawing.Size(121, 21);
            this.player1Bet.TabIndex = 0;
            // 
            // player2Bet
            // 
            this.player2Bet.FormattingEnabled = true;
            this.player2Bet.Location = new System.Drawing.Point(116, 39);
            this.player2Bet.Name = "player2Bet";
            this.player2Bet.Size = new System.Drawing.Size(121, 21);
            this.player2Bet.TabIndex = 1;
            this.player2Bet.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // player3Bet
            // 
            this.player3Bet.FormattingEnabled = true;
            this.player3Bet.Location = new System.Drawing.Point(116, 65);
            this.player3Bet.Name = "player3Bet";
            this.player3Bet.Size = new System.Drawing.Size(121, 21);
            this.player3Bet.TabIndex = 2;
            // 
            // RaceButton
            // 
            this.RaceButton.Location = new System.Drawing.Point(13, 95);
            this.RaceButton.Name = "RaceButton";
            this.RaceButton.Size = new System.Drawing.Size(75, 23);
            this.RaceButton.TabIndex = 6;
            this.RaceButton.Text = "RACE";
            this.RaceButton.UseVisualStyleBackColor = true;
            this.RaceButton.Click += new System.EventHandler(this.RaceButton_Click);
            // 
            // dog1Label
            // 
            this.dog1Label.AutoSize = true;
            this.dog1Label.Location = new System.Drawing.Point(13, 145);
            this.dog1Label.Name = "dog1Label";
            this.dog1Label.Size = new System.Drawing.Size(40, 13);
            this.dog1Label.TabIndex = 10;
            this.dog1Label.Text = "Sparky";
            // 
            // dog2Label
            // 
            this.dog2Label.AutoSize = true;
            this.dog2Label.Location = new System.Drawing.Point(13, 181);
            this.dog2Label.Name = "dog2Label";
            this.dog2Label.Size = new System.Drawing.Size(36, 13);
            this.dog2Label.TabIndex = 11;
            this.dog2Label.Text = "Rover";
            // 
            // dog3Label
            // 
            this.dog3Label.AutoSize = true;
            this.dog3Label.Location = new System.Drawing.Point(13, 217);
            this.dog3Label.Name = "dog3Label";
            this.dog3Label.Size = new System.Drawing.Size(43, 13);
            this.dog3Label.TabIndex = 12;
            this.dog3Label.Text = "Jezebel";
            // 
            // dog6Label
            // 
            this.dog6Label.AutoSize = true;
            this.dog6Label.Location = new System.Drawing.Point(13, 325);
            this.dog6Label.Name = "dog6Label";
            this.dog6Label.Size = new System.Drawing.Size(45, 13);
            this.dog6Label.TabIndex = 15;
            this.dog6Label.Text = "Big Red";
            // 
            // dog5Label
            // 
            this.dog5Label.AutoSize = true;
            this.dog5Label.Location = new System.Drawing.Point(13, 289);
            this.dog5Label.Name = "dog5Label";
            this.dog5Label.Size = new System.Drawing.Size(50, 13);
            this.dog5Label.TabIndex = 14;
            this.dog5Label.Text = "Lightning";
            // 
            // dog4Label
            // 
            this.dog4Label.AutoSize = true;
            this.dog4Label.Location = new System.Drawing.Point(13, 253);
            this.dog4Label.Name = "dog4Label";
            this.dog4Label.Size = new System.Drawing.Size(34, 13);
            this.dog4Label.TabIndex = 13;
            this.dog4Label.Text = "Arrow";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(116, 140);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(176, 23);
            this.progressBar1.TabIndex = 16;
            this.progressBar1.Value = 0;
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(116, 176);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(176, 23);
            this.progressBar2.TabIndex = 17;
            // 
            // progressBar3
            // 
            this.progressBar3.Location = new System.Drawing.Point(116, 212);
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(176, 23);
            this.progressBar3.TabIndex = 18;
            // 
            // progressBar4
            // 
            this.progressBar4.Location = new System.Drawing.Point(116, 248);
            this.progressBar4.Name = "progressBar4";
            this.progressBar4.Size = new System.Drawing.Size(176, 23);
            this.progressBar4.TabIndex = 19;
            // 
            // progressBar5
            // 
            this.progressBar5.Location = new System.Drawing.Point(116, 284);
            this.progressBar5.Name = "progressBar5";
            this.progressBar5.Size = new System.Drawing.Size(176, 23);
            this.progressBar5.TabIndex = 20;
            // 
            // progressBar6
            // 
            this.progressBar6.Location = new System.Drawing.Point(116, 320);
            this.progressBar6.Name = "progressBar6";
            this.progressBar6.Size = new System.Drawing.Size(176, 23);
            this.progressBar6.TabIndex = 21;
            // 
            // dog6Result
            // 
            this.dog6Result.AutoSize = true;
            this.dog6Result.Location = new System.Drawing.Point(298, 325);
            this.dog6Result.Name = "dog6Result";
            this.dog6Result.Size = new System.Drawing.Size(0, 13);
            this.dog6Result.TabIndex = 27;
            // 
            // dog5Result
            // 
            this.dog5Result.AutoSize = true;
            this.dog5Result.Location = new System.Drawing.Point(298, 289);
            this.dog5Result.Name = "dog5Result";
            this.dog5Result.Size = new System.Drawing.Size(0, 13);
            this.dog5Result.TabIndex = 26;
            // 
            // dog4Result
            // 
            this.dog4Result.AutoSize = true;
            this.dog4Result.Location = new System.Drawing.Point(298, 253);
            this.dog4Result.Name = "dog4Result";
            this.dog4Result.Size = new System.Drawing.Size(0, 13);
            this.dog4Result.TabIndex = 25;
            // 
            // dog3Result
            // 
            this.dog3Result.AutoSize = true;
            this.dog3Result.Location = new System.Drawing.Point(298, 217);
            this.dog3Result.Name = "dog3Result";
            this.dog3Result.Size = new System.Drawing.Size(0, 13);
            this.dog3Result.TabIndex = 24;
            // 
            // dog2Result
            // 
            this.dog2Result.AutoSize = true;
            this.dog2Result.Location = new System.Drawing.Point(298, 181);
            this.dog2Result.Name = "dog2Result";
            this.dog2Result.Size = new System.Drawing.Size(0, 13);
            this.dog2Result.TabIndex = 23;
            // 
            // dog1Result
            // 
            this.dog1Result.AutoSize = true;
            this.dog1Result.Location = new System.Drawing.Point(298, 145);
            this.dog1Result.Name = "dog1Result";
            this.dog1Result.Size = new System.Drawing.Size(0, 13);
            this.dog1Result.TabIndex = 22;
            // 
            // Player1Label
            // 
            this.Player1Label.AutoSize = true;
            this.Player1Label.Location = new System.Drawing.Point(33, 17);
            this.Player1Label.Name = "Player1Label";
            this.Player1Label.Size = new System.Drawing.Size(41, 13);
            this.Player1Label.TabIndex = 29;
            this.Player1Label.Text = "Name1";
            // 
            // Player2Label
            // 
            this.Player2Label.AutoSize = true;
            this.Player2Label.Location = new System.Drawing.Point(33, 43);
            this.Player2Label.Name = "Player2Label";
            this.Player2Label.Size = new System.Drawing.Size(41, 13);
            this.Player2Label.TabIndex = 30;
            this.Player2Label.Text = "Name2";
            // 
            // Player3Label
            // 
            this.Player3Label.AutoSize = true;
            this.Player3Label.Location = new System.Drawing.Point(33, 69);
            this.Player3Label.Name = "Player3Label";
            this.Player3Label.Size = new System.Drawing.Size(41, 13);
            this.Player3Label.TabIndex = 31;
            this.Player3Label.Text = "Name3";
            // 
            // Player3CashLabel
            // 
            this.Player3CashLabel.AutoSize = true;
            this.Player3CashLabel.Location = new System.Drawing.Point(251, 69);
            this.Player3CashLabel.Name = "Player3CashLabel";
            this.Player3CashLabel.Size = new System.Drawing.Size(0, 13);
            this.Player3CashLabel.TabIndex = 34;
            // 
            // Player2CashLabel
            // 
            this.Player2CashLabel.AutoSize = true;
            this.Player2CashLabel.Location = new System.Drawing.Point(251, 43);
            this.Player2CashLabel.Name = "Player2CashLabel";
            this.Player2CashLabel.Size = new System.Drawing.Size(0, 13);
            this.Player2CashLabel.TabIndex = 33;
            // 
            // Player1CashLabel
            // 
            this.Player1CashLabel.AutoSize = true;
            this.Player1CashLabel.Location = new System.Drawing.Point(251, 17);
            this.Player1CashLabel.Name = "Player1CashLabel";
            this.Player1CashLabel.Size = new System.Drawing.Size(0, 13);
            this.Player1CashLabel.TabIndex = 32;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Player3CashLabel);
            this.Controls.Add(this.Player2CashLabel);
            this.Controls.Add(this.Player1CashLabel);
            this.Controls.Add(this.Player3Label);
            this.Controls.Add(this.Player2Label);
            this.Controls.Add(this.Player1Label);
            this.Controls.Add(this.dog6Result);
            this.Controls.Add(this.dog5Result);
            this.Controls.Add(this.dog4Result);
            this.Controls.Add(this.dog3Result);
            this.Controls.Add(this.dog2Result);
            this.Controls.Add(this.dog1Result);
            this.Controls.Add(this.progressBar6);
            this.Controls.Add(this.progressBar5);
            this.Controls.Add(this.progressBar4);
            this.Controls.Add(this.progressBar3);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.dog6Label);
            this.Controls.Add(this.dog5Label);
            this.Controls.Add(this.dog4Label);
            this.Controls.Add(this.dog3Label);
            this.Controls.Add(this.dog2Label);
            this.Controls.Add(this.dog1Label);
            this.Controls.Add(this.RaceButton);
            this.Controls.Add(this.player3Bet);
            this.Controls.Add(this.player2Bet);
            this.Controls.Add(this.player1Bet);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox player1Bet;
        public System.Windows.Forms.ComboBox player2Bet;
        public System.Windows.Forms.ComboBox player3Bet;
        private System.Windows.Forms.Button RaceButton;
        private System.Windows.Forms.Label dog1Label;
        private System.Windows.Forms.Label dog2Label;
        private System.Windows.Forms.Label dog3Label;
        private System.Windows.Forms.Label dog6Label;
        private System.Windows.Forms.Label dog5Label;
        private System.Windows.Forms.Label dog4Label;
        public System.Windows.Forms.ProgressBar progressBar1;
        public System.Windows.Forms.ProgressBar progressBar2;
        public System.Windows.Forms.ProgressBar progressBar3;
        public System.Windows.Forms.ProgressBar progressBar4;
        public System.Windows.Forms.ProgressBar progressBar5;
        public System.Windows.Forms.ProgressBar progressBar6;
        private System.Windows.Forms.Label dog6Result;
        private System.Windows.Forms.Label dog5Result;
        private System.Windows.Forms.Label dog4Result;
        private System.Windows.Forms.Label dog3Result;
        private System.Windows.Forms.Label dog2Result;
        private System.Windows.Forms.Label dog1Result;
        public System.Windows.Forms.Label Player1Label;
        public System.Windows.Forms.Label Player2Label;
        public System.Windows.Forms.Label Player3Label;
        public System.Windows.Forms.Label Player3CashLabel;
        public System.Windows.Forms.Label Player2CashLabel;
        public System.Windows.Forms.Label Player1CashLabel;
    }
}


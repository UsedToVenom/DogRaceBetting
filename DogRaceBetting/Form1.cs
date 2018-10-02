using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DogRaceBetting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void player1Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void RaceButton_Click(object sender, EventArgs e){            
            for (int i = 0; i <= 5; i++){
                WinnersTable.winnerDogTable[i] = null;
            }

                PlayerList.GetListOfPlayers()[0].Bet(Int32.Parse(player1Bet.Text), 152);
            PlayerList.GetListOfPlayers()[1].Bet(Int32.Parse(player2Bet.Text), 152);
            PlayerList.GetListOfPlayers()[2].Bet(Int32.Parse(player3Bet.Text), 152);

            PlayerList.GetListOfPlayers()[0].UpdateLegalBetValues();
            Console.WriteLine(PlayerList.GetListOfPlayers()[0].LegalBetValues.GetHashCode());
            PlayerList.GetListOfPlayers()[1].UpdateLegalBetValues();
            PlayerList.GetListOfPlayers()[2].UpdateLegalBetValues();

            player1Bet.Update();

            //Console.WriteLine(player1Bet.DataSource.GetHashCode());


            DogList.race();
            
            Player1CashLabel.Text = PlayerList.GetListOfPlayers()[0].cash.ToString();
            Player2CashLabel.Text = PlayerList.GetListOfPlayers()[1].cash.ToString();
            Player3CashLabel.Text = PlayerList.GetListOfPlayers()[2].cash.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void DogToBetOn1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

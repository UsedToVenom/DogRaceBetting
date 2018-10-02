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


        public string Player1Name
        {
            get { return Player1Label.Text; }
            set { Player1Label.Text = value; }
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

        private void RaceButton_Click(object sender, EventArgs e)
        {
            //get values from player1,2,3Bet fields and dogId  and call bet money with them

            DogList.race();

            //update cash values for players, mark winning dog, reset player 123 bet and dog id fields

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}

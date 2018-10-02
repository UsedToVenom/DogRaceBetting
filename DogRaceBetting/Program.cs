﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DogRaceBetting
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
       public static void Main()
        {
            
           

            

            //Defining players
            Player Steve = new Player("Steve", 150);
            Player John = new Player("John", 200);
            Player Bill = new Player("Bill", 350);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form1 Game = new Form1();

            //adding player names to UI
            Game.Player1Label.Text = PlayerList.GetPlayerNameList()[0];
            Game.Player2Label.Text = PlayerList.GetPlayerNameList()[1];
            Game.Player3Label.Text = PlayerList.GetPlayerNameList()[2];

            //adding player resources to UI
            Game.Player1CashLabel.Text = PlayerList.GetListOfPlayers()[0].cash.ToString();
            Game.Player2CashLabel.Text = PlayerList.GetListOfPlayers()[1].cash.ToString();
            Game.Player3CashLabel.Text = PlayerList.GetListOfPlayers()[2].cash.ToString();

            //Defining race dogs
            RaceDog Sparky = new RaceDog("Sparky");
            RaceDog Rover = new RaceDog("Rover");
            RaceDog Jezebel = new RaceDog("Jezebel");
            RaceDog Arrow = new RaceDog("Arrow");
            RaceDog Lightning = new RaceDog("Lightning");
            RaceDog BigRed = new RaceDog("Big Red");
            
            //simulating results - adding dogs to winner table
            //WinnersTable.addDogToTable(Sparky);
            //WinnersTable.addDogToTable(Jezebel);
            //WinnersTable.addDogToTable(Rover);
            //WinnersTable.addDogToTable(Arrow);
            //WinnersTable.addDogToTable(Lightning);
            //WinnersTable.addDogToTable(BigRed);

            Console.WriteLine("steve had " + Steve.cash);
            Console.WriteLine("John had " + John.cash);
            Console.WriteLine("Bill had " + Bill.cash);
            Console.WriteLine("Bank had " + Bank.bankedCash);

            //simulating functionality
           // John.Bet(10, Jezebel.id);
           // Steve.Bet(101, Sparky.id);
           // Bill.Bet(10, Sparky.id);

            

            Application.Run(Game);


            Console.WriteLine("Bank holds on to " + Bank.totalMoneyBet);

            Console.WriteLine("Winning dog is " + WinnersTable.Winner().name);
            Console.WriteLine("Steve bet on " + Steve.dogBetId);
            Console.WriteLine("Sparky ID is " + Sparky.id);
            Console.WriteLine("Jezebel ID is " + Jezebel.id);
            Console.WriteLine("Rover ID is " + Rover.id);
            

            Console.WriteLine("Steve has " + Steve.cash);
            Console.WriteLine("John has " + John.cash);
            Console.WriteLine("Bill has " + Bill.cash);
            Console.WriteLine("Bank profit " + Bank.profit);


            

            
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogRaceBetting
{
    static class Bank
    {
      public static int bankedCash = 0;
      public static int profit = 0;
      public static int totalMoneyBet = 0;


        public static void collect (int money) {
            bankedCash += money;
        }
        public static void grantWinnings(Player [] listOfPlayers) {
            List <Player> listOfWinners = new List<Player> { };
            int winningDogId = WinnersTable.Winner().id;
            int winningsDelivered = 0;
            int winnersPool = 0;

            for (int i = 0; i < listOfPlayers.Length; i++) {
                if (listOfPlayers[i].dogBetId.Equals(winningDogId)) {
                    listOfWinners.Add(listOfPlayers[i]);
                    winnersPool += listOfPlayers[i].moneyBet;
                }
            }
            for (int i = 0; i < listOfPlayers.Length; i++) {
                totalMoneyBet = totalMoneyBet + listOfPlayers[i].moneyBet;
            }
            for (int i = 0; i < listOfWinners.Count; i++) {
                listOfWinners[i].cash = listOfWinners[i].cash + (int)(((double)(listOfWinners[i].moneyBet)/(winnersPool))*bankedCash);
                winningsDelivered = winningsDelivered + (int)(((double)(listOfWinners[i].moneyBet) / (winnersPool)) * bankedCash);
                listOfWinners[i].moneyBet = 0;

            }
            profit += bankedCash - winningsDelivered;
            bankedCash -= winningsDelivered;
        }
    }
}

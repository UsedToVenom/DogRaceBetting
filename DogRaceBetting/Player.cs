using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogRaceBetting
{
    public class Player
    {
        public string Name { get; set; }
        public int cash { get; set; }
        public int dogBetId { get; set; }
        public int moneyBet { get; set; }

        public Player(string name, int cash){
            this.Name = name;
            this.cash = cash;
            }

        public void Bet(int moneyBet, int dogId)
        {
            if (moneyBet > cash)
            {
                Bank.collect(0);
                dogBetId = -1;
            }
            else
            {
                cash -= moneyBet;
                Bank.collect(moneyBet);
                this.moneyBet = moneyBet;
                dogBetId = dogId;
            }
        }
        
    }
}

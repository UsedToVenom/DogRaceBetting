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

        public List<int> LegalBetValues = new List<int>();

        public Player(string name, int cash){
            this.Name = name;
            this.cash = cash;
            PlayerList.Add(this);
            this.UpdateLegalBetValues();
            }

        public void UpdateLegalBetValues() {
            LegalBetValues.Clear();
            int TempCash = cash;

            while (TempCash >= 10) {
                LegalBetValues.Add(TempCash/10*10);
                TempCash -= 10;
            }
        }

        public void Bet(int moneyToBet, int dogId)
        {
            if (moneyToBet > cash)
            {
                Bank.collect(0);
                dogBetId = -1;
                moneyBet = 0;
            }
            else
            {
                cash -= moneyToBet;
                Bank.collect(moneyToBet);
                moneyBet = moneyToBet;
                dogBetId = dogId;
            }
        }
        
    }
}

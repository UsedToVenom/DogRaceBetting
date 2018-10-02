using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogRaceBetting
{
    class RaceDog
    {
        public string name;
        public int id;

        //parameters for future development
        int speed;
        int endurance;
        int will;
        //

        public bool hasRun = false;
        public int ranMeters = 0;
        public RaceDog(string name) {
            this.name = name;
            this.id = DogIdGenerator.getId();
            DogList.Add(this);
        }

        public void run() {
            if (ranMeters < 100 && ranMeters >=0)
            {
                ranMeters += new Random().Next(10);                
            }
            else if (ranMeters >= 100){
                WinnersTable.addDogToTable(this);
                ranMeters = -1;
                if (WinnersTable.winnerDogTable.Length.Equals(DogList.list.Count)) {
                    Bank.grantWinnings(PlayerList.GetListOfPlayers());
                }
            }
            System.Threading.Thread.Sleep(5);
        }
    }
}

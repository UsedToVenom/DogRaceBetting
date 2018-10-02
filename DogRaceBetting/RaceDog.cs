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
        int speed;
        int endurance;
        int will;
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
            else if (ranMeters >= 0){
                WinnersTable.addDogToTable(this);
                ranMeters = -1;
            }
        }
    }
}

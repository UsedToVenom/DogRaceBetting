using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogRaceBetting
{
    static class WinnersTable
    {
        public static RaceDog[] winnerDogTable = new RaceDog[6];

        public static void addDogToTable(RaceDog dog) {
            for (int i = 0; i <= 5; i++) {
                if (winnerDogTable[i] == null) {
                    winnerDogTable[i] = dog;
                }
            }
        }

        public static RaceDog Winner() {
            return winnerDogTable[0];
        }

    }
}

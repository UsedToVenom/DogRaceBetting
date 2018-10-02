using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogRaceBetting
{
    static class DogList
    {
        public static int length = 0;
        public static List<RaceDog> list = new List<RaceDog> { };

        public static void Add(RaceDog raceDog) {
            list.Add(raceDog);
            length++;
        }

        public static void race()
        {
            for (int i = 0; i < DogList.length;)
            {

                Random randomizer = new Random();
                int randomDog = randomizer.Next(DogList.length - 1);
                if (DogList.list[randomDog].hasRun == false)
                {
                    DogList.list[randomDog].run();
                    if (DogList.list[randomDog].ranMeters == -1)
                    {
                        break;
                    }
                }
                else
                {
                    for (int j = 0; j < DogList.length; j++)
                    {
                        if (DogList.list[j].hasRun == false)
                        {
                            race();
                        }
                    }
                }
                for (int j = 0; j < DogList.length; j++)
                {
                    DogList.list[j].hasRun = false;
                }
                if (DogList.list[randomDog].ranMeters != -1)
                {
                    race();
                }                
            }
        }
    }
}

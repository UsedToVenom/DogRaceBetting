using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogRaceBetting
{
    static class DogIdGenerator
    {
        public static int getId() {
            int candidateId = new Random().Next(1000);

            for (int i = 0; i < DogList.length; i++) {
                if (DogList.list[i].id == candidateId){

                    candidateId = getId();
                }
            }
            
                return candidateId;
                        
        }
    }
}

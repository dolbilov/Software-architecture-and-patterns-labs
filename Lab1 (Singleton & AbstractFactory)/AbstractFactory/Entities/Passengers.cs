using System.Collections.Generic;
using DAOSS_1_2.Abstact_classes;

namespace DAOSS_1_2.Entities
{
    public class Passengers
    {
        public List<AbstractPassenger> passengers;

        public Passengers(int passengersCount)
        {
            passengers = new List<AbstractPassenger>(passengersCount);
        }
    }
}
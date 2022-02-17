using DAOSS_1_2.Abstact_classes;
using DAOSS_1_2.Interfaces;

namespace DAOSS_1_2.Entities
{
    public class BusFactory : IFactory
    {
        public AbstractDriver CreateDriver()
        {
            return new BusDriver();
        }

        public Passengers CreatePassengers()
        {
            return new Passengers(30);
        }
    }
}
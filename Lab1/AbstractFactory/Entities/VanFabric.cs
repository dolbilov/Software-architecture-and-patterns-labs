using DAOSS_1_2.Abstact_classes;
using DAOSS_1_2.Interfaces;

namespace DAOSS_1_2.Entities
{
    public class VanFabric : IFactory
    {
        public AbstractDriver CreateDriver()
        {
            return new VanDriver();
        }

        public Passengers CreatePassengers()
        {
            return new Passengers(100);
        }
    }
}
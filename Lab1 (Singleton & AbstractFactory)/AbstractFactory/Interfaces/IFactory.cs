using DAOSS_1_2.Abstact_classes;
using DAOSS_1_2.Entities;

namespace DAOSS_1_2.Interfaces
{
    public interface IFactory
    {
        public AbstractDriver CreateDriver();

        public Passengers CreatePassengers();
    }
}
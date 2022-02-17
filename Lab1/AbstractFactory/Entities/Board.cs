using DAOSS_1_2.Abstact_classes;
using DAOSS_1_2.Interfaces;

namespace DAOSS_1_2.Entities
{
    public class Board
    {
        public AbstractDriver driver;
        public Passengers passengers;

        public Board(IFactory factory)
        {
            driver = factory.CreateDriver();
            passengers = factory.CreatePassengers();
        }
        
        public override string ToString()
        {
            return $"This is board.\ndriver: {driver}\npassengers: {passengers.passengers.Capacity}";
        }
    }
}
namespace DAOSS_2
{
    public class Passenger
    {
        private readonly PassengerType _passengerType;

        public Passenger(PassengerType passengerType)
        {
            _passengerType = passengerType;
        }

        public override string ToString()
        {
            return $"This is a passenger. Type: {_passengerType.ToString()}";
        }
    }

    public enum PassengerType
    {
        Adult,
        Child,
        Discounted
    }
}
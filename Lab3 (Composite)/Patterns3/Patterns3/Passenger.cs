namespace Patterns3;

public class Passenger : PlanePart
{
    public PassengerType passengerType;
    public float extraPayment = 0;

    public Passenger(PassengerType type)
    {
        passengerType = type;

        weight = Rnd.RandomInt(5, 61);

        switch (passengerType)
        {
            case PassengerType.Economy:
                if (weight > 20)
                {
                    extraPayment = 100;
                }
                break;
            case PassengerType.Business:
                if (weight > 35)
                {
                    extraPayment = 50;
                }
                break;
            case PassengerType.First:
                extraPayment = 0;
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(passengerType));
        }
    }

    public override float SummaryWeight()
    {
        return weight;
    }
}

public enum PassengerType
{
    Economy,
    Business,
    First
}
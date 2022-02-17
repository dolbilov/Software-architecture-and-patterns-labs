namespace DAOSS_2
{
    public class Driver
    {
        private readonly DriverType _driverType;

        public override string ToString()
        {
            return $"This is a driver with {_driverType.ToString()} licence";
        }

        public Driver(DriverType driverType)
        {
            _driverType = driverType;
        }
    }

    public enum DriverType
    {
        Bus,
        Taxi,
        Boat
    }
}
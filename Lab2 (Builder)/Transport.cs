using System.Collections.Generic;
using System.Text;

namespace DAOSS_2
{
    public class Transport
    {
        public List<Passenger> Passengers;

        public Driver Driver;

        public TransportType transportType;

        public override string ToString()
        {
            StringBuilder sb = new();
            sb.Append($"This is a {transportType.ToString()}.\nWith driver: {Driver}.\nThere are {Passengers.Count} passengers:\n");
            for (int i = 0; i < Passengers.Count; i++)
            {
                sb.Append($"Passenger {i + 1}. Type: {Passengers[i]}\n");
            }

            return sb.ToString();
        }
    }

    public enum TransportType
    {
        Bus,
        Taxi
    }
}
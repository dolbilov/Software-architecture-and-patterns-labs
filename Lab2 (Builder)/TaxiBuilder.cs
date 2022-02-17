using System;
using System.Collections.Generic;

namespace DAOSS_2
{
    public class TaxiBuilder : Builder
    {
        public override void CreateDriver()
        {
            _transport.Driver = new Driver(DriverType.Taxi);
        }

        public override void CreatePassengers()
        {
            const int passengersCount = 4;
            _transport.Passengers = new List<Passenger>(passengersCount);
            Random rnd = new();
            for (var i = 0; i < passengersCount; i++)
            {
                var passengerType = (PassengerType) rnd.Next(2);
                _transport.Passengers.Add(new Passenger(passengerType));
            }
        }

        public override void SetTransportType()
        {
            _transport.transportType = TransportType.Taxi;
        }
    }
}
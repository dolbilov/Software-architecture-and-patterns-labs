using System;
using System.Collections.Generic;

namespace DAOSS_2
{
    public class BusBuilder : Builder
    {
        public override void CreateDriver()
        {
            _transport.Driver = new Driver(DriverType.Bus);
        }

        public override void CreatePassengers()
        {
            const int passengersCount = 30;
            _transport.Passengers = new List<Passenger>(passengersCount);
            Random rnd = new();
            for (var i = 0; i < passengersCount; i++)
            {
                var passengerType = (PassengerType) rnd.Next(3);
                _transport.Passengers.Add(new Passenger(passengerType));
            }
        }

        public override void SetTransportType()
        {
            _transport.transportType = TransportType.Bus;
        }
    }
}
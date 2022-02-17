using System;
using DAOSS_1_2.Entities;

namespace DAOSS_1_2
{
    public class Program
    {
        private static void Main()
        {
            var taxiFactory = new TaxiFactory();
            var busFactory = new BusFactory();

            var taxi1 = new Board(taxiFactory);
            Console.WriteLine(taxi1);

            Console.WriteLine("\n-------------\n");

            var bus1 = new Board(busFactory);
            Console.WriteLine(bus1);

            var vanFabric = new VanFabric();
        }
    }
}
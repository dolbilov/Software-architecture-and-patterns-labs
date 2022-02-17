using System;

namespace DAOSS_2
{
    public class Program
    {
        private static void Main()
        {
            Director dir = new();
            BusBuilder bb = new();
            TaxiBuilder tb = new();
            
            Transport bus1 = dir.CreateTransport(bb);
            Console.WriteLine(bus1);

            Console.WriteLine("\n\n----------------\n\n");

            Transport taxi1 = dir.CreateTransport(tb);
            Console.WriteLine(taxi1);
        }
    }
}
namespace Patterns3;

public static class Program
{
    private static void Main()
    {
        Cabin plane = new Cabin();

        var economyPassengers =
            Enumerable.Repeat(new Passenger(PassengerType.Economy), 150);
        PlanePart economyCabin = new Cabin(economyPassengers);

        var businessPassengers =
            Enumerable.Repeat(new Passenger(PassengerType.Business), 20);
        PlanePart businessCabin = new Cabin(businessPassengers);

        var firstPassengers =
            Enumerable.Repeat(new Passenger(PassengerType.First), 10);
        PlanePart firstCabin = new Cabin(firstPassengers);

        plane.Parts.Add(economyCabin);
        plane.Parts.Add(businessCabin);
        plane.Parts.Add(firstCabin);


        var summaryWeight = plane.SummaryWeight();
        Console.WriteLine($"Summary weight: {summaryWeight}");

        Console.Write("Enter maximum weight of plane: ");
        var weight = Convert.ToDouble(Console.ReadLine());
        if (summaryWeight > weight)
        {
            var toRemove = summaryWeight - weight;
            if (toRemove > economyCabin.SummaryWeight())
            {
                Console.WriteLine("Can't remove that much baggage. Flight was cancelled.");
                Environment.Exit(-1);
            }
            else
            {
                Console.WriteLine($"{toRemove} kilogram(s) were removed from plane");
            }
        }
        else
        {
            Console.WriteLine("Don't need to remove baggage.");
        }
        Console.WriteLine("Have a good trip!");
    }
}
namespace Pattern6;

public static class Program
{
    private static void Main()
    {
        DeanOffice deanOffice = new DeanOffice();

        Teacher t1 = new Teacher("Teacher_1");
        t1.AddObserver(deanOffice);

        Teacher t2 = new Teacher("Teacher_2");
        t2.AddObserver(deanOffice);

        Teacher t3 = new Teacher("Teacher_3");
        t3.AddObserver(deanOffice);

        Console.WriteLine("Week 1");
        t1.NotifyObservers();
        t2.NotifyObservers();
        t3.NotifyObservers();
        Console.WriteLine(deanOffice.CheckReports());

        Console.WriteLine("\nWeek 2");
        deanOffice.NextWeek();
        t1.NotifyObservers();
        t2.NotifyObservers();
        Console.WriteLine(deanOffice.CheckReports());

        Console.WriteLine("\nWeek 3");
        deanOffice.NextWeek();
        t2.NotifyObservers();
        t3.NotifyObservers();
        Console.WriteLine(deanOffice.CheckReports());


        Console.WriteLine("\nWeek 4");
        deanOffice.NextWeek();
        t1.RemoveObserver(deanOffice);
        t2.NotifyObservers();
        t3.NotifyObservers();
        Console.WriteLine(deanOffice.CheckReports());

        Console.WriteLine("\nWeek 5");
        deanOffice.NextWeek();
        t2.RemoveObserver(deanOffice);
        t3.NotifyObservers();
        Console.WriteLine(deanOffice.CheckReports());
    }
}
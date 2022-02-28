using System;

namespace DAOSS
{
    public class Program
    {
        private static void Main(string[] args)
        {
            var config = Config.Instance;
            Console.WriteLine("From Main():");
            Console.WriteLine(config);
            Console.WriteLine();

            var cnt = new Connector();
        }
    }
}
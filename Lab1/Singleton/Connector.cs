using System;

namespace DAOSS
{
    public class Connector
    {
        public Connector()
        {
            var config = Config.Instance;
            Console.WriteLine("From Connector constructor:");
            Console.WriteLine(config.ToString());
        }
    }
}
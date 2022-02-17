namespace DAOSS_2
{
    public class Director
    {
        public Transport CreateTransport(Builder builder)
        {
            builder.CreateDriver();
            builder.CreatePassengers();
            builder.SetTransportType();

            return builder.GetTransport();
        }
    }
}
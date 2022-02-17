namespace DAOSS_2
{
    public abstract class Builder
    {
        protected Transport _transport;

        public Builder()
        {
            Reset();
        }

        virtual public void CreateDriver() {}

        virtual public void CreatePassengers() {}
        
        virtual public void SetTransportType() {}

        public Transport GetTransport()
        {
            return _transport;
        }

        public void Reset()
        {
            _transport = new Transport();
        }
    }
}
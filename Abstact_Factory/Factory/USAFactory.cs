namespace Abstact_Factory
{
    public class USAFactory : TransportFactory
    {
        public Aircraft CreateAircraft()
        {
            return new Boening747();
        }

        public Car CreateCar()
        {
            return new Porsche();
        }
    }
}
namespace Abstact_Factory
{
    public class RussianFactory : TransportFactory
    {
        public Aircraft CreateAircraft()
        {
            return new TU134();
        }

        public Car CreateCar()
        {
            return new Niva();
        }
    }
}
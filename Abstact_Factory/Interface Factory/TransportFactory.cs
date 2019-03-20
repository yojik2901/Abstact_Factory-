namespace Abstact_Factory
{
    //Фабрика по созданию транспортных средств
    public interface TransportFactory
    {
        //что фабрика будет производить
        Car CreateCar();

        Aircraft CreateAircraft();
    }
}
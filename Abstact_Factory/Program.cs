using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstact_Factory
{
    class Program
    {
        private static TransportFactory factory;

        static void Main(string[] args)
        {

            if (true)
                factory = new RussianFactory();
            else
            {
                factory = new USAFactory();
            }

            Aircraft aircraft = factory.CreateAircraft();

            aircraft.flight();
        }
    }
}

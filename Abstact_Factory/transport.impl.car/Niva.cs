using System;

namespace Abstact_Factory
{
    public class Niva : Car
    {
        public void drive()
        {
            Console.WriteLine("Niva drive");
        }

        public void stop()
        {
            Console.WriteLine("Niva stopped");
        }
    }
}
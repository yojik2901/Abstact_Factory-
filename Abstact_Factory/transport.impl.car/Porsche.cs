using System;

namespace Abstact_Factory
{
    public class Porsche : Car
    {
        public void drive()
        {
            Console.WriteLine("Porsche drive");
        }

        public void stop()
        {
            Console.WriteLine("Porsche stopped");
        }
    }
}
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var car = new Car();
            car.run();
            car.stop();
        }
    }

    interface IVehiculable
    {
        public void run();
        public void stop();
    }
    class Car : IVehiculable
    {
        public void stop()
        {
            Console.WriteLine("paro");
        }
        public void run()
        {
            Console.WriteLine("arranco desde coche");
        }
    }
}

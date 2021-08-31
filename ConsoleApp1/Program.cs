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
    abstract class Vehiculable
    {
        public void run()
        {
            Console.WriteLine("arranco desde la clase abstacta");
        }
    }

    interface IVehiculable
    {
        //public void run();
        public void stop();
    }
    class Car : Vehiculable, IVehiculable
    {
        public void stop()
        {
            Console.WriteLine("paro");
        }
        new public void run()
        {
            Console.WriteLine("arranco desde coche");
        }
    }
}

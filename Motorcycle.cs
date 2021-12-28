using System;
namespace FactoryPatternApp
{
    public class Motorcycle : IVehicle
    {
        public Motorcycle()
        {
        }

        public void Drive()
        {
            Console.WriteLine("The motorcycle is revving up");
        }
    }
}

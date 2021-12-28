using System;
namespace FactoryPatternApp
{
    public class ThreeWheeler : IVehicle
    {
        public ThreeWheeler()
        {
        }

        public void Drive()
        {
            Console.WriteLine("Let's get out of here!");
        }
    }
}

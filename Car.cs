using System;
namespace FactoryPatternApp
{
    public class Car : IVehicle
    {
        public Car()
        {
        }

        public void Drive()
        {
            Console.WriteLine("This car is driving!");
        }
    }
}

using System;

namespace FactoryPatternApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfWheels;
            bool input = false;

            do
            {
                Console.WriteLine("Enter the amount of tires for the vehicle you would like to create:");
                input = int.TryParse(Console.ReadLine(), out numberOfWheels);
            } while (!input);

            var vehicle = VehicleFactory.GetVehicle(numberOfWheels);
            vehicle.Drive();
           
        }
    }
}

using System;

namespace FactoryPatternExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            bool input = false;
            int numOfWheels;
            do
            {
                Console.WriteLine("Enter the amount of tires for the vehicle you want to create");
               

                 input = int.TryParse(Console.ReadLine(), out numOfWheels);

            } while (input == false);
            var vehicle = Vehiclefactory.GetVehicle(numOfWheels);
            vehicle.Drive();
            
        }
    }
}

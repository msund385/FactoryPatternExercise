using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExercise
{
    public class Motorcycle : IVehicle
    {
        public void Drive()
        {
            ConsoleLogger.VehicleStartUpDialogue();
            Console.WriteLine("The Motorcycle is reving up!!!!");
            Console.WriteLine("vrooooooom");
        }
    
    }
}

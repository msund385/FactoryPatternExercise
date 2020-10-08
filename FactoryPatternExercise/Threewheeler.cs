using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExercise
{
    class Threewheeler : IVehicle
    {
      public void Drive()
        {
            ConsoleLogger.VehicleStartUpDialogue();
            Console.WriteLine("Let's get going!!!!");
        }
    }
}

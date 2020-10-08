using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExercise
{
    public static class Vehiclefactory
    {
        public static IVehicle GetVehicle(int wheelCount)
        {
            switch (wheelCount)
            {
                case 2:
                    return new Motorcycle();
                case 3:
                    return new Threewheeler();
                case 4 :
                    return  new Car();
                default:
                    return new Car();
            }   
            
              
            
        }
    
    }
}

using System;
using System.Collections.Generic;

namespace Garage
{
    public class Cessna : Vehicle, IGasVehicle  // Propellor light aircraft
    {
        public double CurrentTankPercentage { get; set;} = 10;
        public double FuelCapacity { get; set; }


        public void RefuelTank()
        {
             CurrentTankPercentage = 100;
            // method definition omitted
        }
        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Cesna flashes by you like a hurricane. Zooooom!");
        }
        public override void Stop()
        {
            Console.WriteLine($"The {MainColor} Cesna rolls down the runway for a mile and stops.");
            Console.WriteLine();
        }
    }
}

using System;
using System.Collections.Generic;

namespace Garage
{
    public class Ram : Vehicle, IGasVehicle // Gas powered truck
    {
        public double FuelCapacity { get; set; }
        public double CurrentTankPercentage { get; set;} = 20;
        public void RefuelTank()
        {
            CurrentTankPercentage = 100;
            // method definition omitted
        }
        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Ram growls by you RRrrrrrummbbble!");
        }
    }
}

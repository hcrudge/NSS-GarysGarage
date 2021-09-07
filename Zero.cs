using System;
using System.Collections.Generic;

namespace Garage
{
    public class Zero : Vehicle, IElectricVehicle   // Electric motorcycle
    {
        public double BatteryKWh { get; set; }
        public double CurrentChargePercentage { get; set; } = 10;
        public void ChargeBattery()
        {
            // Console.WriteLine($"Your Zero now charged to {BatteryKWh}KWH.");
            CurrentChargePercentage = 100;
            // method definition omitted
        }
        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Zero zips by you. Yeeeeoooowwww!");
        }
    }
}

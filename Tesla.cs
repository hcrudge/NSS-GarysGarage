using System;
using System.Collections.Generic;

namespace Garage
{
    public class Tesla : Vehicle, IElectricVehicle  // Electric car
    {
        public double BatteryKWh { get; set; }
        public double CurrentChargePercentage { get; set; } = 20;

        public void ChargeBattery()
        {
            // Console.WriteLine($"Your Tesla now charged to {BatteryKWh}KWH.");
            CurrentChargePercentage = 100;
            // method definition omitted
        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Tesla blazes by you. Mmmmmmm!");
        }

        public override void Turn(string direction)
        {
            Console.WriteLine($"The {MainColor} Tesla squeals around a {direction} turn.");
       
        }
        public override void Stop()
        {
            Console.WriteLine($"The {MainColor} Tesla silently stops as if it never moved.");
            Console.WriteLine();
        }
    }
}

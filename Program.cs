using System;
using System.Collections.Generic;

namespace Garage
{
    class Program
    {
        static void Main(string[] args)
        {
            Zero fxs = new Zero { MainColor = "Midnight Blue", MaximumOccupancy = 1, BatteryKWh = 200 };
            Zero fxz = new Zero { MainColor = "Black", MaximumOccupancy = 1, BatteryKWh = 200};
            Tesla modelS = new Tesla { MainColor = "Burgundy", MaximumOccupancy = 2, BatteryKWh = 200 };

            List <IElectricVehicle> electricVehicles = new List<IElectricVehicle> () {
                fxz, fxs, modelS
            };

            Console.WriteLine("Electric Vehicles");
            foreach(IElectricVehicle ev in electricVehicles)
            {
                Console.WriteLine($"Current Charge Percentage: {ev.CurrentChargePercentage}");
            }

            foreach(IElectricVehicle ev in electricVehicles)
            {
                // This should charge the vehicle to 100%
                ev.ChargeBattery();
            }

            foreach(IElectricVehicle ev in electricVehicles)
            {
                Console.WriteLine($"Updated Charge Percentage:{ev.CurrentChargePercentage}");
            }


            Ram x1500 = new Ram { MainColor = "Silver", MaximumOccupancy = 20, FuelCapacity = 800 };
            Cessna mx410 = new Cessna { MainColor = "White", MaximumOccupancy = 5, FuelCapacity = 1200 };

             List<IGasVehicle> gasVehicles = new List<IGasVehicle>() {
                x1500, mx410
            };

            Console.WriteLine("Gas Vehicles");
            foreach(IGasVehicle gv in gasVehicles)
            {
                Console.WriteLine($"Current Fuel Percentage: {gv.CurrentTankPercentage}");
            }

            foreach(IGasVehicle gv in gasVehicles)
            {
                // This should completely refuel the gas tank
                gv.RefuelTank();
            }

            foreach(IGasVehicle gv in gasVehicles)
            {
                Console.WriteLine($"Updated Fuel Percentage: {gv.CurrentTankPercentage}");
            }



            // fxs.Drive();
            // fxs.Turn("left");
            // fxs.Stop();
            // fxz.Drive();
            // fxz.Turn("left");
            // fxz.Stop();
            // modelS.Drive();
            // modelS.Turn("left");
            // modelS.Stop();
            // mx410.Drive();
            // mx410.Turn("left");
            // mx410.Stop();
            // x1500.Drive();
            // x1500.Turn("left");
            // x1500.Stop();
        }


    }
}

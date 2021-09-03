using System;
using System.Collections.Generic;

namespace Garage
{
    class Program
    {
        static void Main(string[] args) 
        {
            Zero fxs = new Zero {MainColor="Midnight Blue", MaximumOccupancy=1, BatteryKWh=200};
            Zero fxz = new Zero {MainColor="Black", MaximumOccupancy= 1, BatteryKWh = 200};
            Tesla modelS = new Tesla {MainColor="Burgundy", MaximumOccupancy = 2, BatteryKWh = 200};
            Cessna mx410 = new Cessna {MainColor="White", MaximumOccupancy=5, FuelCapacity=1200};
            Ram x1500 = new Ram {MainColor="Silver", MaximumOccupancy=20, FuelCapacity=800 };

            fxs.Drive();
            fxs.Turn("left");
            fxs.Stop();
            fxz.Drive();
            fxz.Turn("left");
            fxz.Stop();
            modelS.Drive();
            modelS.Turn("left");
            modelS.Stop();
            mx410.Drive();
            mx410.Turn("left");
            mx410.Stop();
            x1500.Drive();
            x1500.Turn("left");
            x1500.Stop();
        }
   
   
    }
}

using System;

namespace Garage
{
    public interface IGasVehicle
    {
         public double CurrentTankPercentage { get;} 
        void RefuelTank();

    }
}
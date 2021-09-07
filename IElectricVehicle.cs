using System;

namespace Garage
{
    public interface IElectricVehicle
    {
        public double CurrentChargePercentage { get; } 
        void ChargeBattery();
    }
}
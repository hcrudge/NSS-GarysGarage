using System;
using System.Collections.Generic;

namespace Garage
{
    public class Vehicle
    {
        public string MainColor { get; set; }
        public int MaximumOccupancy { get; set; }

        public virtual void Drive()
        {
            Console.WriteLine("Vroom!");
        }

        public virtual void Turn(string direction)
        {
            Console.WriteLine($"The vehicle carefully turns {direction}.");
        }   

        public virtual void Stop()
        {
            Console.WriteLine("The vehicle gently rolls to a stop!");
            Console.WriteLine();
        } 
    
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Ex01Vehicles
{
    public class Bus : Vehicle 
    {
        public Bus(double fuelQuant, double fuelConsump, double tankCap) : base(fuelQuant, fuelConsump, tankCap)
        {
        }

        public override void Drive(double distance, double adding)
        {
            double consumedFuel = distance * (FuelConsump + adding);
            if (FuelQuant - consumedFuel >= 0)
            {
                FuelQuant -= consumedFuel;
                Console.WriteLine($"Bus travelled {distance} km");
            }
            else
            {
                Console.WriteLine($"Bus needs refueling");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Ex01Vehicles
{
    public class Truck : Vehicle
    {
        public Truck(double fuelQuant, double fuelConsump,double tankCap) : base(fuelQuant, fuelConsump,tankCap)
        {
        }

        public override void Drive(double distance, double adding)
        {
            double consumedFuel = distance * (FuelConsump + adding);
            if (FuelQuant - consumedFuel >= 0)
            {
                FuelQuant -= consumedFuel;
                Console.WriteLine($"Truck travelled {distance} km");
            }
            else
            {
                Console.WriteLine($"Truck needs refueling");
            }
        }

    }
}

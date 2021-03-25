using System;
using System.Collections.Generic;
using System.Text;

namespace Ex01Vehicles
{
    public class Car : Vehicle
    {
        public Car(double fuelQuant, double fuelConsump, double tankCap) : base(fuelQuant, fuelConsump,tankCap)
        {
        }

        public override void Drive(double distance, double adding)
        {
            double consumedFuel = distance * (FuelConsump + adding);
            if (FuelQuant - consumedFuel >= 0)
            {
                 FuelQuant -= consumedFuel;
                Console.WriteLine($"Car travelled {distance} km");
            }
            else
            {
                Console.WriteLine($"Car needs refueling");
            }
        }
    }
}

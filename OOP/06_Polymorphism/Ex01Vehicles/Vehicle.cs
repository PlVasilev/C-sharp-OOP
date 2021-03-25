using System;
using System.Collections.Generic;
using System.Text;

namespace Ex01Vehicles
{
    public abstract class Vehicle
    {
        private double fuelQuant;

        public double FuelQuant {
            get => fuelQuant;
            set
            {
                if (value > TankCap)
                {
                    fuelQuant = 0;
                }
                else
                {
                    fuelQuant = value;
                }
            }
        }
        public double FuelConsump { get; private set; }
        public double TankCap { get; private set;}

        public Vehicle(double fuelQuant, double fuelConsump,double tankCap)
        {
            TankCap = tankCap;
            FuelQuant = fuelQuant;
            FuelConsump = fuelConsump;
            
        }

        public abstract void Drive(double distance,double adding);

        public void Refuel(double fuel)
        {
            string vehicle = GetType().Name;
            if (fuel <= 0)
            {
                Console.WriteLine($"Fuel must be a positive number");
            }
            else if (vehicle == "Truck")
            {
                if (fuel * 0.95 + FuelQuant > TankCap)
                {
                    Console.WriteLine($"Cannot fit {fuel} fuel in the tank");
                }
                else
                {
                    FuelQuant += fuel * 0.95;
                }
            }
            else if (fuel + FuelQuant > TankCap)
            {
                Console.WriteLine($"Cannot fit {fuel} fuel in the tank");
            }
            else
            {
                FuelQuant += fuel;
            }  
        }
    }
}

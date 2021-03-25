using System;
using System.Collections.Generic;
using System.Text;


public abstract class Driver
{
    private double speed;

    public Driver(string name, Car car, double fuelComsumption)
    {
        Name = name;
        TotalTime = 0;
        Car = car;
        FuelConsumptionPerKm = fuelComsumption;
        Speed = (Car.Hp + Car.Tyre.Degradation) / Car.FuelAmount;
    }

    public string Name { get; private set; }
    public double TotalTime { get; private set; }
    public Car Car { get; private set; }
    public double FuelConsumptionPerKm { get; private set; }

    public double Speed
    {
        get { return speed; }
        set { speed = (Car.Hp + Car.Tyre.Degradation) / Car.FuelAmount; }
    }


}


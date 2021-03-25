using System;
using System.Collections.Generic;
using System.Text;

public class Car
{
    private double fuelAmount;

    public Car(int hp, double fuelAmount, Tyre tyre)
    {
        Hp = hp;
        FuelAmount = fuelAmount;
        Tyre = tyre;
    }

    public int Hp { get; private set; }

    public Tyre Tyre { get; set; }

    public double FuelAmount
    {
        get { return fuelAmount; }
        set
        {
            if (fuelAmount < 0)
            {
                throw new Exception("Out of fuel");
            }
            else if (fuelAmount > 160)
            {
                fuelAmount = 160;
            }
            else
            {
                fuelAmount = value;
            }
        }
    }

}


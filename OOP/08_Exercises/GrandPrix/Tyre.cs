using System;
using System.Collections.Generic;
using System.Text;


public abstract class Tyre
{
    private double degradation;

    public Tyre(string name, double hardness)
    {
        Name = name;
       this.hardness = hardness;
        Degradation = 100;
    }

    public string Name { get; private set; }
    public double hardness { get; protected set; }


    public double Degradation
    {
        get { return degradation; }
        set
        {
            if (value < 0)
            {
                throw new Exception("Blown Tyre");
            }
            else if (this.Name == "UltraSoft")
            {
                if (value < 30)
                {
                    throw new Exception("Blown Tyre");
                }
            }
            degradation = value;
        }
    }
    
}


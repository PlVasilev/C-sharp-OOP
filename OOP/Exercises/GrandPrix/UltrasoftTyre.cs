using System;
using System.Collections.Generic;
using System.Text;


public class UltrasoftTyre : Tyre
{
    public UltrasoftTyre(string name, double hardness, double grip) : base(name, hardness)
    {
        Grip = grip;
    }

    public double Grip { get; private set; }
}


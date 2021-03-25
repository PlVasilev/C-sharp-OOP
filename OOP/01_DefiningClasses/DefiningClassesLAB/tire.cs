using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class tire
    {
        public double Pressure1 { get; set; }
        public double Pressure2 { get; set; }
        public double Pressure3 { get; set; }
        public double Pressure4 { get; set; }

        public tire(double pressure1, double pressure2, double pressure3, double pressure4)
        {
            Pressure1 = pressure1;
            Pressure2 = pressure2;
            Pressure3 = pressure3;
            Pressure4 = pressure4;
        }
    }
}
